USE [BV_KHAM_CHUA_BENH]
GO
/****** Object:  StoredProcedure [dbo].[SpgetVienPhi]    Script Date: 09/12/2017 14:12:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
ALTER PROCEDURE [dbo].[SpgetVienPhi]
	-- Add the parameters for the stored procedure here
	@MA_LOAI_KCB AS INT,
	@NGAYTTBD AS VARCHAR(8),
	@NGAYTTKT AS VARCHAR(8)
AS
BEGIN
	DECLARE   @SQLQuery AS NVARCHAR(MAX)
	DECLARE   @PivotColumns AS NVARCHAR(MAX)

	SELECT @PivotColumns = COALESCE(@PivotColumns + ',','') + QUOTENAME(MA_NHOM) 
	FROM (SELECT DISTINCT MA_NHOM FROM NHOM WHERE MA_NHOM != '4') AS Nhom
	
	SET   @SQLQuery = 
    N'SELECT HO_TEN,DIA_CHI,NGAY_VAO,NGAY_RA,SO_NGAY_DTRI,MA_LOAI_KCB,
    ([1] * MUC_HUONG) AS [1],
    ([2] * MUC_HUONG) AS [2],
    ([3] * MUC_HUONG) AS [3],
    ([4] * MUC_HUONG) AS [4],
    ([5] * MUC_HUONG) AS [5],
    ([6] * MUC_HUONG) AS [6],
    ([7] * MUC_HUONG) AS [7],
    ([8] * MUC_HUONG) AS [8],
    ([9] * MUC_HUONG) AS [9],
    ([10] * MUC_HUONG) AS [10],
    ([11] * MUC_HUONG) AS [11],
    ([12] * MUC_HUONG) AS [12],
    ([13] * MUC_HUONG) AS [13],
    ([14] * MUC_HUONG) AS [14],
    ([15] * MUC_HUONG) AS [15],
    ROW_NUMBER() OVER(ORDER BY THONGTIN_CT.MA_LK ASC) AS STT
    FROM (SELECT MA_LK,HO_TEN,DIA_CHI,CONVERT(VARCHAR,CONVERT(DATETIME,SUBSTRING(NGAY_VAO,1,8)),3)AS NGAY_VAO,
    CONVERT(VARCHAR,CONVERT(DATETIME,SUBSTRING(NGAY_RA,1,8)),3)AS NGAY_RA,SO_NGAY_DTRI,MA_LOAI_KCB,
    (CAST((100-MUC_HUONG)AS Float)/CAST(100 AS Float)) AS MUC_HUONG 
			 FROM THONGTIN_CT 
			 WHERE (CAST(SUBSTRING(NGAY_TTOAN,1,8) AS DATE) <= CAST('''+@NGAYTTKT+''' AS DATE) AND CAST(SUBSTRING(NGAY_TTOAN,1,8) AS DATE) >= CAST('''+@NGAYTTBD+''' AS DATE))
			 AND T_BNTT>0 
			 ) AS THONGTIN_CT 
    LEFT OUTER JOIN
    (SELECT MA_LK, ' +   @PivotColumns + '
    FROM (SELECT MA_LK,MA_NHOM,SUM(THANH_TIEN) AS THANH_TIEN FROM DVKT_CT GROUP BY MA_LK,MA_NHOM) AS DichVuKyThuat 
    PIVOT( SUM(THANH_TIEN) 
          FOR MA_NHOM IN (' + @PivotColumns + ')) AS DichVu ) AS DICHVU_CT 
    ON THONGTIN_CT.MA_LK = DICHVU_CT.MA_LK 
    LEFT OUTER JOIN 
    (SELECT MA_LK, [4]
    FROM (SELECT MA_LK,NHOM,SUM(THANH_TIEN) AS THANH_TIEN FROM THUOC_CT GROUP BY MA_LK,NHOM) AS ThuocCT 
    PIVOT( SUM(THANH_TIEN) 
          FOR NHOM IN ([4])) AS Thuoc ) AS TTHUOC_CT 
    ON THONGTIN_CT.MA_LK = TTHUOC_CT.MA_LK '
    
	IF(@MA_LOAI_KCB != 0)
		SET @SQLQuery = @SQLQuery + ' WHERE MA_LOAI_KCB = '+ CONVERT(varchar(10), @MA_LOAI_KCB)
	
	--SELECT   @SQLQuery
	--Execute dynamic query
	EXEC sp_executesql @SQLQuery
	
END
