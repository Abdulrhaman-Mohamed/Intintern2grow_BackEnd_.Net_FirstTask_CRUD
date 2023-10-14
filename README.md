First Task in Intern2grow Back-end
This is the README file for my first task in the Intern2grow back-end internship. The task involves creating CRUD (Create, Read, Update, Delete) operations using .NET Core 7 Web API.

Task Description
The task is to implement a Blogger API that allows users to perform the following actions:

Creation: Users can create a new blog post by providing the content and attaching an image.
Update: Users can update their existing blog posts by providing new content and the post ID.
Read: Users can retrieve all the posts from the database with pagination, displaying the first 10 posts per page.
Delete: Users can delete their blog posts by specifying the post ID.
Tools Used
For this project, I used the following tools and technologies:

.NET Core 7: The framework used for building the Web API.
Entity Framework: A popular Object-Relational Mapping (ORM) tool for working with databases in .NET applications.
LINQ: Language-Integrated Query (LINQ) is used to query data from different data sources.
Fluent API: A flexible and powerful way to configure the Entity Framework models and relationships.
Code First (Migration): The Code First approach allows the database schema to be generated from the code.
Getting Started
To run this project locally, please follow these steps:

Clone the repository to your local machine.
Install the required dependencies using the package manager or NuGet.
Configure the database connection string in the appsettings.json file.
Run the database migrations to create the necessary tables and schema.
Build and run the project.
bash
Copy
git clone https://github.com/your-username/your-repository.git
cd your-repository
dotnet restore
# Update the database connection string in appsettings.json
dotnet ef database update
dotnet build
dotnet run
Once the project is running, you can access the Blogger API endpoints using a tool like Postman or any web browser.

API Endpoints
The following API endpoints are available:

POST /api/posts: Create a new blog post.
PUT /api/posts/{id}: Update an existing blog post by ID.
GET /api/posts: Retrieve all blog posts with pagination.
DELETE /api/posts/{id}: Delete a blog post by ID.
Please refer to the API documentation or code for more details on the request and response formats for each endpoint.
