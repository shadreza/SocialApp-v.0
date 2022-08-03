# SocialApp-v.0

#### This app will have the main consumers in a live messaging platform. They will be able to view other's profiles and can make friends. They will be able to chat with friends and see posts as well...

### This app will be working with both the frontend and backend part. 

 - #### Frontend -> Angular
 - #### Backend -> ASP DOTNET 6
 - #### Database -> SQlite (initially -> MongoDb inshaALLAH)

##### This total learning will be divided into section following the course 

## Section 01
Worked untill making a simple Get API. 
GetUser(id) -> get a single user as the id
GetUsers -> get all the users of the database  

Key things

 1. Change some of the dotnet 6 styles into the dotnet 5 or the classical approach. Like adding the Startup.cs
 2. In API.csproj we are currently commenting the **< Nullable >enable</ Nullable >** and for that the **?** sign must be kept hidden
 3. Make a folder named **Entities** and made a c# class named **AppUser.cs** where the initial user properties are laid down. Like it will get id and name for the properties
 4. Make another folder named **Data** and add a class as **DataContext.cs** where it will be invoking the **DbContext** which will help to make the commands in our app map the sql commands in the database. Also the **DbSet** entity can be used to query and save instances of **AppUser**. This will come in handy in the API system as the **Users** property will do the stuff in the database part.
 5. While initializing the sqlite we are getting the initial migrate files and the record ones that will be history book.  This will be under Data / Migrations
 6. In **appsettings.Development.json** we are giving the **ConnectionString** where **DefaultConnection** resides and the **'Data source=socialapp.db'** is kept. In **Startup.cs** we are using this connection string for the connection with the database. When we are bringing in the **IConfiguration** **_config** as the context next we are using it in the **service** section and calling the **AddDbContext< DataContext >** and within that we are using the sqlite function to set the connection string from the **DefaultConnection**
 7. For getting more information from the api hits we are using the **Information** property in **"Microsoft.AspNetCore"** in **appsettings.Development.json**
 8. Added obj, bin to gitignore
 9. Made a new **Controller** named **UserController.cs** where the main api is written. here the **[ApiController]** is used. Also the route is set as **[Route("api/[controller]")]**. The **UsersController** is invoking the **ControllerBase** and the **_context** is set with **DataContext**. Made 2 api one to get all the users and the other to get a single one with the id. Also making the functions async for the scalability perspective.

One demonstration of making the http function an async one. 
Use async **keyword** after **public** [accessmodifier]
Wrap the return type with the **Task** (comes from **System.Threading.Tasks**) 
use **await** keyword after return
lastly use the **Async** version of the method like **FindAsync()** or **ToListAsync()**

		// api/users/1

		[HttpGet("{id}")]

		public  async  Task<ActionResult<AppUser>>  GetUser(int  id)

		{

			return  await  _context.Users.FindAsync(id);

		}  

## ~~End of Section 01~~
