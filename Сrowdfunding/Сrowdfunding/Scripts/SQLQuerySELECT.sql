CREATE PROC [dbo].[UserSelect] 
	@Id int 
AS 
	SET NOCOUNT ON 
	SET XACT_ABORT ON 

	BEGIN TRAN 

	SELECT [Id], [UserName], [Email], [EmailConfirmed], [PasswordHash], [PhoneNumber], [ImageUrl]
	FROM [dbo].[Users]	 
	WHERE ([Id] = @Id OR @Id IS NULL) 
	COMMIT
GO