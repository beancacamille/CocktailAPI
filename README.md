# Cocktail API

## Project Overview

The aim of this project is to deliver a test framework for the TheCocktailDB API. By working in pairs, we hope to to incorporate good collaboration using GitHub, follow the scrum model by holding regular stand-ups and reviews and work closely together to carry out tests for the service.

## Class Diagram



# Sprint Breakdown

## Sprint 1

The aim of this sprint is to find a free API for this project and setting up the GitHub repository.

IMAGE OF BOARD

### Sprint Goals

* [ ] User Story 1 - Choose API
* [ ] User Story 2 - Setup GitHub
* [ ] User Story 3.1 - Setup Framework Solution
* [ ] User Story 3.2 - Create folders
* [ ] User Story 3.3 - Create classes
* [ ] User Story 4.1 - Test outputs
* [ ] User Story 5.1 - Test outputs
* [ ] User Story 4.2 - Ingredients in cocktails
* [ ] User Story 5.2 - Ingredients check
* [ ] Agile documentation

### Sprint Review

The purpose of this sprint is to find an appropriate API to test and set up the framework. This was achieved quickly, as TheCocktailDB allows for users to GET requests whilst being free to use, meaning that more testing than expected was completed. The split in work between the two of us has meant that our work does not cause conflicts when pushing to GitHub.

### Sprint Retrospective

When using branches from the dev branch on GitHub to upload our individual updates onto the same project, we didn't encounter and problems from this sprint. Initially, when pulling updates to our local repo, some files weren't loading into the Visual Studio file, but this was solved early and we could continue our updates.

## Sprint 2

This is the final sprint and the aim is to tidy up the existing code and refactor any necessary sections. All the documentation should be completed by the end of this sprint.

IMAGE OF BOARD

### Sprint Goals

* [ ] User Story 6 - Refactoring
* [ ] Agile documentation completed

### Sprint Review

Having completed almost all of the project in the previous sprint, this sprint was less intense, focused on the quality of the code. Some tests were altered to have more descriptive names as well as method names too. The dev branch was updated to have all other branches merged with no conflicts.

### Sprint Retrospective 

The use of branches really helped merge the updates, allowing for small alterations to be made continuously. This sprint meant that we could do work at our own pace without the need for calls but still communicated about the individual work we had completed.

# Project Review

The project requirements were met

Using GitHub collaboratively success

Branches were effective

SCRUM framework kept us organised and focused

Improve user stories next time

# Project Retrospective

Good work distribution

Good communication - calls initially

IMAGE OF BOARD COMPLETE

# How to Use CocktailDB API Framework
For this project, we used the services:
- Search cockail by name
- Search ingredient by name
### Search cocktail by name service
#### Initialisation
```csharp
var searchByCocktailService = new SCService("cocktail name");
```
The constructor has a string parameter that will be used when calling the API.
#### Service methods
```csharp
public Drink[] GetResult()
```
This method returns an array of Drink objects that correspond to the string value passed in when initialising the service. If there are no results, the array will be `null`.
```csharp
public bool CheckAllCocktailsContainSearchInput()
```
This method returns a boolean value on whether all of the results contain the string value passed in when initialising the service.
```csharp
public List<string> GetIngredients()
```
This method returns a list of string of ingredients of the first result.
### Search ingredient by name service
#### Initialisation
```csharp
var searchByIngredientService = new SIService();
```
#### Service methods
```csharp
public int CountAllIngredients()
```
This method returns an integer value of the total amount of reults returned when calling the API.
```csharp
public int CountIngredientSearched(string liquid)
```
This method takes in a string value that will be used to filter the results and return an integer value of the amount of filtered results.
```csharp
public string GetIngredientSearched(string liquid)
```
This method takes in a string value that will be used to filter the results and return a string value of the first result. If there are no results, it will return `""`.