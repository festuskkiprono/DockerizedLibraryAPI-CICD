##  Overview

This is a small-scale Library Management API that showcases modern .NET development practices, containerization, and DevOps automation. It provides full CRUD operations for managing a library's book collection and author information with a focus on data persistence and automated image deployment to Docker repository.

##  What I Built & Learned

### Core Development Skills
* **Built RESTful APIs** using ASP.NET Core 10 with proper HTTP methods and status codes
* **Implemented Data Access Layer** using Entity Framework Core
* **Designed Database Schema** with proper relationships (one-to-many) between the two entities
* **Handled Model Binding** and validation for incoming requests

### Docker & Containerization
* **Wrote multi-stage Dockerfiles** to optimize image size and build efficiency
* **Used Docker volumes** for data persistence when containers restart
* **Configured Docker networks** for inter-container communication
* **Created Docker Compose** to manage multi-container applications
* **Managed environment variables** and configuration in containerized environments


In preparation for continuous integration (CI) I did the following:

* Wrote multi-stage Dockerfiles to optimize image size and build efficiency
* Used Docker volumes for data persistence when containers restarts
* Configured Docker networks for inter-container communication
* Created Docker Compose to manage multi-container applications
* Managed environment variables and configuration in containerized environments

## CD

To implement Continuous deployment I did the following:

* Set up GitHub Actions workflow for automated builds
* Configure Docker registry authentication using GitHub Secrets
* Automate image building and pushing to Docker Hub on every commit

## Database Management

* Create and apply EF Core migrations for database schema versioning
* Configure database context with SQL Server provider
* Handle connection strings securely using secrets.json
* Run migrations in Docker containers for automated database setup

## Future work

Going forward I will be implementing the following workflows
* Automated Testing on Push
* Build Docker image only if tests pass
