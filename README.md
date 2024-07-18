# APP FileDBImport

This project compares two strategies for importing a CSV file into a PostgreSQL database.

## Technologies Used:
- .NET 8
- PostgreSQL
- Dapper

## INSERT Strategy:
In this strategy we use an INSERT for each line of the CSV. In the example, we have a file with 78,777 lines, requiring 78,777 trips to the database to complete the import.

## BULK Strategy:
In this strategy we use BULK with blocks of 10,000 records, reducing the number of trips to the database to 8.

# Conclusion
The BULK strategy proves to be much more efficient. By inserting blocks of 10,000 records, it can be up to 21 times faster.

[![Watch the video](https://img.youtube.com/vi/RAU6lfvrLKs/default.jpg)](https://youtu.be/RAU6lfvrLKs)
```mermaid
sequenceDiagram
    participant User
    participant APP
    participant PostgreSQL

    User ->> APP: Starts processing
    APP ->> APP: Reads 10,000 lines from the CSV file
    alt Block of 10,000 records completed
        APP ->> PostgreSQL: BULK INSERT into instruments table
        PostgreSQL ->> APP: Insertion confirmation
    end

```
