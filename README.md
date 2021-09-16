# Chat-Online :newspaper: 
 Creating an app that provides a way for friends to communicate with each other. Providing storage of messages assigned to specific conversations and the ability to have a group of friends assigned to an account.
 
# TODO 🥊
1. [:heavy_check_mark:] Create ASP.NET CORE MVC PROJECT
2. [:x:] Create website design template
     - [:heavy_check_mark:] Create register form
     - [:heavy_check_mark:] Create loggin form
     - [:x:] Create chat design
       - [:x:] Add search bar [top side]
       - [:x:] Add friends list [left side]
       - [:x:] Add place to chat message
3. [:x:] Create database with Entity Framework (Model First approach)
      - [:x:] Create integration test (CRUD operations) 
4. [:x:] Create user from register form
     - [:x:] Hash user password 
     - [:x:] Save user credentials to database
5. [:x:] Loggin to website page with credentials
     - [:x:] Create authorization token after correct loggin
     - [:x:] Add authorization token to all page request
     - [:x:] Load data from database base on token and visualize it
6. [:x:] Create another user
7. [:x:] Create option to search users
8. .....
9. .....
10. ....
# Solution :hammer:
## 1. Create ASP.NET CORE MVC <br>
Find short name of ASP.NET.CORE MVC:
```
dotnet new --list
```
Execute
```
dotnet new mvc
```
To add .gitignore to project, execute
```
dotnet new gitignore
```
You can also create a project by Visual Studio

## 2. Create website design template

### 2.1 Create register form
<img src="https://user-images.githubusercontent.com/44371092/133685651-f75eb5c7-145b-4ad1-90d7-520dc36f0c1b.png"/>

### 2.2 Create loggin form
<img src="https://user-images.githubusercontent.com/44371092/133682048-ccf89803-3d0f-411e-89dd-2bc912a8b277.png"/>

### 2.3 Create register form
### 2.4 Create chat design
#### 2.4.1 Add search bar [top side]
#### 2.4.2 Add friends list [left side]
#### 2.4.3 Add place to chat message
  
