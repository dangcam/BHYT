USE [BV_KHAM_CHUA_BENH]
GO
/****** Object:  StoredProcedure [dbo].[SpSuaDVKT_CT]    Script Date: 09/14/2017 14:00:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<DangCam>
-- Create date: <17/05/2017>
-- Description:	<ThemTienGiuong>
-- =============================================
CREATE PROCEDURE [dbo].[SpSuaDVKT_CTCSL]
	-- Add the parameters for the stored procedure here
@MA_LK AS varchar(100),
@MA_DICH_VU AS varchar(20),
@KET_QUA AS nvarchar(50) = null
AS
BEGIN
UPDATE DVKT_CT SET
KET_QUA = @KET_QUA
WHERE MA_LK = @MA_LK AND MA_DICH_VU=@MA_DICH_VU
END
