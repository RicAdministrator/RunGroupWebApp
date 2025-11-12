## Database
How to Drop Create a DB:
1. Open SSMS > Connect to SQL server
2. Package Manager Console > Default project: RunGroupWebApp
3. Package Manager Console > Run "cls"
4. Package Manager Console > Run "Drop-Database"
5. A confirmation will appear, input "y" then press enter
6. SSMS > Refresh Databases > check if "RunGroups" db was deleted
7. Package Manager Console > Run "Update-Database". This will create the db.
8. Check tables > run Database\CheckDataAfterDropCreateSeed.sql > tables should have 0 rows
9. Package Manager Console > pwd
10. Make sure you are one folder above the Migrations folder (\RunGroupWebApp\RunGroupWebApp). Peform cd if needed (E.g. cd RunGroupWebApp)
11. Package Manager Console > dotnet run seeddata
12. Check tables > run Database\CheckDataAfterDropCreateSeed.sql > tables should have rows

How to Create a Single Migration File:
1. In windows file explorer, delete all files in Migrations folder
2. In VS, you will notice that the Migrations folder is gone
3. Package Manager Console > Default project: RunGroupWebApp
4. Package Manager Console > Run "cls"
5. Package Manager Console > Run "Add-Migration Initial"
6. Check Migrations folder > migration files should be created

## Others
Notes:
1. C:\Users\Richard\source\repos\RunGroupWebApp
2. super_user_1@gmail.com : P@ssword1
3. user_1@gmail.com : P@ssword1