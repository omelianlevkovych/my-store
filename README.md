# my-store


# project structure
Store.Domain is mostly responsible for holding all our models for the app; therefore modelying our domain.  
Store.Application is responsible for handling our domain; it's basically pipeline between DB, Domain and UI.  
You can also think about Store.Application as an API to work with the domain objects.  
