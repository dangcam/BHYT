USE [BV_KHAM_CHUA_BENH]
GO
/****** Object:  UserDefinedFunction [dbo].[getVienPhi]    Script Date: 09/12/2017 15:30:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<DangCam>
-- Create date: <28/01/2016>
-- Description:	<getNhapKho>
-- =============================================
ALTER FUNCTION [dbo].[getCanLamSan]
(
	@NGAYTTBD AS VARCHAR(8),
	@NGAYTTKT AS VARCHAR(8)
)
RETURNS TABLE 
AS
RETURN 
(
	--- ROW_NUMBER() OVER(ORDER BY MA_BN ASC) AS STT,
	(SELECT MA_LK,ROW_NUMBER() OVER(ORDER BY MA_BN ASC) AS STT,
		HO_TEN,DIA_CHI,NGAY_VAO,NGAY_RA,MA_LOAI_KCB,
		SO_NGAY_DTRI
	FROM THONGTIN_CT WHERE 
	 (CAST(SUBSTRING(NGAY_TTOAN,1,8) AS DATE) <= CAST(@NGAYTTKT AS DATE)
	AND CAST(SUBSTRING(NGAY_TTOAN,1,8) AS DATE) >= CAST(@NGAYTTBD AS DATE)))
	
)
