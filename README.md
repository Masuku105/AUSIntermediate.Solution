# AUSIntermediate.Solution
#How to bootstrap the application

 #1.Open the project using Visual Studio
 
 #2.Navigate to the appsettings file
 
 #3.Change the connection string as folllows:
  <Server=YourSqlServerName;Database=DesiredDbName;userid=id;password=mypwd Trusted_Connection=True;MultipleActiveResultSets=true> 
  *Remove the username and password if your server is set up to windows authentication. 
  
 #4.On visual studion open up packet manager console.
 
 #5.Select AUSIntermediate.Solution.ServiceLayer as your defualt project.
 
 #6.On the Packet Manager Controller run the command >update-database.

When all of these steps are done correctly, the application will create the database on your local server 
and add some seed data to get you started. You can than add, update, delete your own users using the app.
