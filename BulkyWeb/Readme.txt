
git clone 
https://github.com/dsmofficial2000/Bulky.git

navigate the repositiory
cd Bulky

check branch
git branch -a


All code is available in Dev branch take a pull of dev
git pull origin Dev

add your database essential information in appsettings.json file

{
  "Logging": {
    "LogLevel": {
      "Default": "Information",
      "Microsoft.AspNetCore": "Warning"
    }
  },
  "AllowedHosts": "*",
  "ConnectionStrings": {
    "DefaultConnection": "Server=DESKTOP-JIVCILV\\SQLEXPRESS; Database=BulkyNew; Trusted_Connection=True;TrustServerCertificate=True"
  }
}


chnage the server name and database name



Additional Tips
If you want to create a local branch that tracks the remote Dev branch, you can do so with the following commands:
-- git checkout -b Dev origin/Dev


Migration is already preasent into the database just update the database /Bulky.DataAccess/


use below commnad
update-database

