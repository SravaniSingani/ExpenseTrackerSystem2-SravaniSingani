# ExpenseTrackerSystem2

## Overview
The expense tracking system helps users log and track their personal spendings. Users can view their expense history and track spending patterns. Users have the ability to update information on monthly expenses and observe spending patterns in every category.

## Features
- Log expenses
- Track expenses in a card
- Filter expenses by categories
- Delete an expense
- Update an existing expense

## CRUD Functionalities
  
- **Card Entity**
  - Create: Add new cards 
  - Read: View existing cards
  - Update: Update card details
  - Delete: Remove cards from the account
  
- **Expense Entity**
  - Create: Add new expenses 
  - Read: View expense details
  - Update: Update expense information
  - Delete: Remove expenses from the system
  
- **Category Entity**
  - Create: Add new categories
  - Read: View existing categories
  - Update: Update category details
  - Delete: Remove categories from the system

## Relational Database
### Entity Relation Diagram
- Category Entity: One-to-many relationship between Category Entity to Expense
- Card Entity: One-to-many relationship between Card Entity to Expense

### Table Relationships
- Cards can have multiple expenses
- Each expense belongs to one category

## Future Additions
- Search for a specific entry
- Filter spendings by date
- View maximum spendings by category
- Visualize expenses with bar plots or charts to see maximum spending on each card or category
