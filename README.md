### How to set up and run the app
1. Paste connection string into the `appsettings.json` file
2. In the Package Manager Console, run:
   ```
   PM> Add-Migration Initial -OutputDir "Database/Migrations"
   PM> Update-Database
   ```
3. Build the app
4. Run it with the "seeddata" command line argument at the first run. For example, in the solution directory, execute
   
   ```
   dotnet run --project "MVC\MVC.csproj" seeddata
   ```
5. If the browser doesn't open, go to http://localhost:5192 manually (you might have to write another port here).
