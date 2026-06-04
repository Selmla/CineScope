# CineScope

## Project overview

CineScope is a school project built with ASP.NET Core MVC and Entity Framework Core. It is a movie catalog app where users can view movies, see details and reviews, and authenticated users can leave reviews. Admin users can manage movies with create, edit, and delete operations.

## What I implemented

This project includes the following functionality:

- Movie data model with:
  - Title
  - Genre
  - Release year
  - Rating
  - Duration
  - Poster URL
  - Description
  - Related reviews
- Review data model with:
  - Content
  - Rating (1-10)
  - UserId and UserName of the reviewer
  - Movie relation
  - CreatedAt timestamp
- SQLite database persistence via `AppDbContext` and `cinescope.db`
- ASP.NET Core Identity for authentication and authorization
- Role support for `Admin` and `Member`
- `Admin` role is required for movie management actions
- Anonymous users can view movie list and details
- Authenticated users can submit reviews on the movie details page
- Search by movie title on the movies index page
- Server-side validation for movie rating and review content

## Why this is level 4 of the implementation instructions

Based on the code and features implemented, this project demonstrates the following level 4 capabilities:

- A working relational model with movies and reviews
- User authentication and role-based authorization
- CRUD operations for movies restricted to admin users
- Review creation for signed-in users
- Search functionality in the movie list
- Proper validation on model properties
- A usable UI flow with login/register and movie detail pages

## How to run the app

1. Open the project folder in Visual Studio or VS Code.
2. Make sure the .NET SDK is installed.
3. Run the project with:
   ```bash
   dotnet run
   ```
4. Open a browser and go to `https://localhost:5001` or the URL shown in the console.

## How to test the app

### 1. View movies and search

- Go to the `Movies` page.
- Verify the movie list loads.
- Use the search field to find movies by title.
- Click on a movie to open its details page.

### 2. Review page and review posting

- On the movie details page, confirm that existing reviews are shown.
- If not signed in, the page should show a message saying login is required to leave a review.
- Register a new user or login with an existing account.
- After signing in, return to a movie details page and submit a review with a rating and text.
- Confirm the review appears immediately after submitting.

### 3. Admin movie management

- The app seeds the `Admin` and `Member` roles automatically.
- The account with email `nayomi.arvell@test.com` is intended to be assigned the `Admin` role if it exists.
- Admin users can create, edit, and delete movies from the `Movies` area.
- If you need to test admin features, log in as the admin account or assign an account to the `Admin` role in the Identity database.

### 4. Validation checks

- Try submitting a review without content or with a rating outside 1-10 and confirm validation prevents it.
- Try creating or editing a movie and confirm rating must be between 0 and 10.

## Notes for the teacher

- The app uses a local SQLite database file named `cinescope.db`.
- There is no hard-coded movie data seed in the project, so the first admin login can create movies manually.
- Anonymous users can browse and view details, but only signed-in users can submit reviews.
- The `MoviesController` correctly restricts create/edit/delete actions to `Admin` and allows review submission for `Member` or `Admin` roles.
