USE [sms]
GO

DECLARE	@return_value Int

EXEC	@return_value = [dbo].[st_getRoles]

SELECT	@return_value as 'Return Value'

GO
