CREATE PROC [dbo].[UserInsert]
	@UserName NVARCHAR (450),
    	@Email NVARCHAR (256),
    	@EmailConfirmed BIT,
    	@PasswordHash NVARCHAR (MAX),
    	@PhoneNumber NVARCHAR (MAX),
    	@ImageUrl NVARCHAR (MAX)
AS
	SET NOCOUNT ON
	SET XACT_ABORT ON

	BEGIN TRAN

	INSERT INTO [dbo].[Users] ([UserName], [Email], [EmailConfirmed], [PasswordHash], [PhoneNumber], [ImageUrl])
	SELECT @UserName, @Email, @EmailConfirmed, @PasswordHash, @PhoneNumber, @ImageUrl

	SELECT [Id], [UserName], [Email], [EmailConfirmed], [PasswordHash], [PhoneNumber], [ImageUrl]
	FROM [dbo].[Users]
	WHERE [Id] = SCOPE_IDENTITY()
	COMMIT
GO