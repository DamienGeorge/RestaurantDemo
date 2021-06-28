CREATE PROCEDURE [dbo].[spFetchUsers]
AS
begin
set nocount on;
	SELECT [Id], [UserName], [NormalizedUserName], 
	[Email], [NormalizedEmail], [EmailConfirmed], 
	[PasswordHash], [SecurityStamp], [ConcurrencyStamp], 
	[PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], 
	[LockoutEnd], [LockoutEnabled], [AccessFailedCount] 
	from dbo.AspNetUsers
end
