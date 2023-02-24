# IdentityFrameworkWithMVC

This is a demo project for depicting the use of Identity Framework and OAuth in Asp.net Core MVC.
Using identity framework, users need to authenticate/login before accessing the content. 

It allows developers to:
- create tables for registration
- create tables for sessions
- create column to store password and secure them
- create pages for login, registration
- maintain sessions, etc.
    
& end Users to:
- Self-registration
- Self-service for
- Forgot password
- Change password
- Configure 2FA
- Configure Profile
- Use exisitng credentials(fb, google, linkedIn, github, etc.)
  
### Microsoft implements all of these using identity framework.
  
## Steps involved in creating this project:
- Create a new MVC Core app with Authentication as Individual Account
- Add a controller named Banking
- Add four actions: BankingInfo, ContactBanking, TransferFunds, DownloadStatements
- Add views for all four views.
- Write something relevant to these. Do not worry, we will just display some info.
- Update layout page for all actions in _layour.cshtml under shared folder.
  - Add navigation bar for each like this: 
      
      &lt;li class="nav-item"&gt;
        
	&lt;a class="nav-link text-dark" asp-area="" asp-controller="Banking" asp-action="DownloadStatements">Statements&lt;/a&gt;
      
      &lt;/li&gt;
  - Do the same for each action mentioned above.
- In the appsettings.json, change the connection string to your servername and db name
- Build app - tools - package manager console
- Add Migrations inititalSetup
- Update-Database to create a new database if not as per the connection string and add lots of tables in that db
- In the controller- use the below 2 attributes for security:
  - [Authorize] with controller
  - [AllowAnonymous] with action - give acces to any1
- Run the site, check the access to pages you will be redirected to login page, register, confirm email link, check the db , ASPNET USER TABLE, CHECk
PASSWORD COLUMN LOGIN AND BROWSE.
- Configure OAuth (fb, google, twitter, linkedIn, etc.)
  - Add the nuget package for them
  - add the config in your program.cs
	  - here u need to obtain clientId and clientSecret from the privder(ex fb)
								AppId and AppSecret
    - for facebook: developers.facebook.com
    - for google: console.cloud.google.com
    - For guidance, check this out: https://developers.google.com/adwords/api/docs/guides/authentication
