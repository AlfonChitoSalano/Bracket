Feature:  Bracket Valid Checker

Scenario Outline: Valid bracket placement
    Given I have a string "<input>"
    When I check if the brackets are correct or not
    Then the result should be valid

Examples:
    | input              |
    | <>                 |
    | Go there           |
    | <Go there>         |
    | <<Go there>>       |
    | ""                 |
    | ''                 |
    | " "                |
    | ' '                |
    | <><>               |
    | <><><>             |
    | <><><><>           |
    | <><><><><>         |
    | <><><><><><>       |
    | <>Go there<>       |
    | <> Go there <>     |
    | <>Go there<> <>    |
    | <> Go there <> <>  |
    | <><>Go there <>    |
    | <><> Go there <>   |
    | <><>Go there<><>   |
    | <><> Go there <><> |
    | Alfon              |
    | <Alfon> <Chito>    |
    | <<Alfon> Chito>    |


Scenario Outline: Not valid bracket placement
    Given I have a string "<input>"
    When I check if the brackets are correct or not
    Then the result should be not valid

Examples:
    | input            |
    | <                |
    | >                |
    | <<>              |
    | <>>              |
    | ><               |
    | ><>              |
    | <><              |
    | <Go there        |
    | Go there>        |
    | <Go there>>      |
    | <<Go there>      |
    | <<Go there       |
    | Go there>>       |
    | <<Alfon> Chito>> |
   
