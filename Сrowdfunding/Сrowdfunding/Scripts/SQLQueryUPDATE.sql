CREATE PROC [dbo].[UserUpdate]
	@Id INT,
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

	UPDATE [dbo].[Users]
	SET  [UserName] = @UserName, [Email] = @Email, [EmailConfirmed] = @EmailConfirmed, [PasswordHash] = @PasswordHash,
	[PhoneNumber] = @PhoneNumber, [ImageUrl] = @ImageUrl
	WHERE [Id] = @Id

	SELECT [Id], [UserName], [Email], [EmailConfirmed], [PasswordHash], [PhoneNumber], [ImageUrl]
	FROM [dbo].[Users]
	WHERE [Id] = @Id
	COMMIT
GO