# Sociable9

This application has been set up to ask for both a unique email and username upon registration
The username is used for login purposes

The application has been configured to use SendGrid API for email verification (key managed by user secrets)

Upon first migration for the database, the following will be created :
admin user :
username : admin
password : Dx9xo9xd!

4 sample categories : Family, Friend, Work, Other

11 contacts with general information with username : 11contacts (create user with username 11contacts to view, unless using admin)
1 contact with general information with username : 1contact (create user with username 1contact to view, unless using admin)

The admin user can see all contacts, including the associated username and creation date
The admin user has the privilege to modify the username and creation date associated with each contact

The normal users can only see their contacts, and do not see the username associated with the contact (as it is inherently their own)
The normal users cannot specify or modify the creation date, only the admin user can do this

