# ShoppingCartAPI built in .NET 6.0

.NET6 standard reference application, demonstrating CQRS application architecture. If you're new to CQRS, read the CQRS in Microservices guide.

Along with the CQRS pattern, the MediatR pattern is implemented to setup the custom project pipeline and prevent dependencies injection in controller layer. Please read about the MediatR pattern for more information CQRS with MediatR
 
# Project Structure

All of the business logic is written in Application layer, currently we don't have Infrastructure layer implemented but if require to call external services or database context, we should be introducing that layer.

# Documentation

Swagger has been implemented to provide the api documentation. 

# Test cases

All the test cases has been written in XUnit. 

# Running Locally

You can simply download the code and run it on your local machine.