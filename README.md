<!DOCTYPE html>
<html>
<body>
  <h1>First Task in Intern2grow Back-end</h1>

  <h2>Task Description</h2>
  <p>The task is to implement a Blogger API that allows users to perform the following actions:</p>
  <ol>
    <li>Creation: Users can create a new blog post by providing the content and attaching an image.</li>
    <li>Update: Users can update their existing blog posts by providing new content and the post ID.</li>
    <li>Read: Users can retrieve all the posts from the database with pagination, displaying the first 10 posts per page.</li>
    <li>Delete: Users can delete their blog posts by specifying the post ID.</li>
  </ol>

  <h2>Tools Used</h2>
  <p>For this project, I used the following tools and technologies:</p>
  <ul>
    <li>.NET Core 7: The framework used for building the Web API.</li>
    <li>Entity Framework: A popular Object-Relational Mapping (ORM) tool for working with databases in .NET applications.</li>
    <li>LINQ: Language-Integrated Query (LINQ) is used to query data from different data sources.</li>
    <li>Fluent API: A flexible and powerful way to configure the Entity Framework models and relationships.</li>
    <li>Code First (Migration): The Code First approach allows the database schema to be generated from the code.</li>
  </ul>

  <h2>Getting Started</h2>
  <p>To run this project locally, please follow these steps:</p>
  <ol>
    <li>Clone the repository to your local machine.</li>
    <li>Install the required dependencies using the package manager or NuGet.</li>
    <li>Configure the database connection string in the <code>appsettings.json</code> file.</li>
    <li>Run the database migrations to create the necessary tables and schema.</li>
    <li>Build and run the project.</li>
  </ol>
  <pre><code>git clone https://github.com/your-username/your-repository.git
cd your-repository
dotnet restore
# Update the database connection string in appsettings.json
dotnet ef database update
dotnet build
dotnet run
  </code></pre>
  <p>Once the project is running, you can access the Blogger API endpoints using a tool like Postman or any web browser.</p>

  <h2>API Endpoints</h2>
  <p>The following API endpoints are available:</p>
  <ul>
    <li><strong>POST /api/posts</strong>: Create a new blog post.</li>
    <li><strong>PUT /api/posts/{id}</strong>: Update an existing blog post by ID.</li>
    <li><strong>GET /api/posts</strong>: Retrieve all blog posts with pagination.</li>
    <li><strong>DELETE /api/posts/{id}</strong>: Delete a blog post by ID.</li>
  </ul>
 
  <p>Thank you for your interest and contribution!</p>
</body>
</html>
