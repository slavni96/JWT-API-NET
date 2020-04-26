# JWT-API-NET

Simple implementation of JWT API Auth in .NET Framework 4.7.2

# Useful information

> JwtManager.cs

Here you will generate the token from a secret string. Remember to generate a new one.

> Filters/JwtAuthenticationAttribute

Definition of the attribute [JwtAuthentication] to indicate methods or controller that require JWT authentication

> Controller/TokenController

Here you will be able to perform simple authentication and data validation