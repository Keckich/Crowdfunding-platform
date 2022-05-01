CREATE PROC [dbo].[UserDelete]
	@Id INT
	AS
	SET NOCOUNT ON
	SET XACT_ABORT ON

	BEGIN TRAN
	
	DELETE
	FROM [dbo].[Users]
	WHERE [Id] = @Id
	COMMIT