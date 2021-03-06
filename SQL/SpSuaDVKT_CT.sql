USE [BV_KHAM_CHUA_BENH]
GO
/****** Object:  StoredProcedure [dbo].[SpSuaDVKT_CT]    Script Date: 09/12/2017 14:16:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<DangCam>
-- Create date: <17/05/2017>
-- Description:	<ThemTienGiuong>
-- =============================================
ALTER PROCEDURE [dbo].[SpSuaDVKT_CT]
	-- Add the parameters for the stored procedure here
@MA_LK AS varchar(100),
@MA_DICH_VU AS varchar(20),
@MA_VAT_TU AS varchar(50),
@MA_NHOM AS varchar(4),
@TEN_DICH_VU AS nvarchar(255),
@DON_VI_TINH AS nvarchar(50),
@SO_LUONG AS int,
@DON_GIA AS int,
@TYLE_TT AS int,
@THANH_TIEN AS int,
@MA_KHOA AS varchar(3),
@MA_BAC_SI AS varchar(20),
@MA_BENH AS varchar(100),
@NGAY_YL AS varchar(12),
@NGAY_QK AS varchar(12),
@MA_PTTT AS int,
@KET_QUA AS nvarchar(50) = null
AS
BEGIN
UPDATE DVKT_CT SET
MA_VAT_TU=@MA_VAT_TU,
MA_NHOM=@MA_NHOM,
TEN_DICH_VU=@TEN_DICH_VU,
DON_VI_TINH=@DON_VI_TINH,
SO_LUONG=@SO_LUONG,
DON_GIA=@DON_GIA,
TYLE_TT=@TYLE_TT,
THANH_TIEN=@THANH_TIEN,
MA_KHOA=@MA_KHOA,
MA_BAC_SI=@MA_BAC_SI,
MA_BENH=@MA_BENH,
NGAY_YL=@NGAY_YL,
NGAY_QK=@NGAY_QK,
MA_PTTT=@MA_PTTT,
KET_QUA = @KET_QUA
WHERE MA_LK = @MA_LK AND MA_DICH_VU=@MA_DICH_VU
END
