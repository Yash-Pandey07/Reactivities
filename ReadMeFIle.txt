//to run the project
//Get into API
dotnet run

//to restore all the dependencies to whole project
dotnet restore
//adding the dotnet ef from website
dotnet tool install --global dotnet-ef --version 7.0.0
dotnet tool update --global dotnet-ef --version 7.0.12

//creating migrations
dotnet ef migrations add InitialCreate -s API -p Persistence

//run and include migrations
//Get into API
dotnet watch

dotnet watch --no-hot-reload

//VITE
npm create vite@latest
cd client-app
npm install  
npm run dev 

//Extensions
react dev tool
Axios 

