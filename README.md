# Epicodus Week 6 Day 5 Word Counter

## Author(s)

  * Steven Colburn

## Date

06/29/2018

## Specifications

  * Create Word Class
    * Word Contains the word to search for and the list of words to search against.
    * User input two strings with the first string used too search through a list created from the second string.
  * RepeatCounter class
    * Used for counting number of times a word exist in a string of words.
  * Test Cases:
    * Calling Default() on a Word object should return true.
    * Input: (string "testOne",string "testOne testTwo")
      * Output: int 1
      * Basic test.
    * Input: (string "testTwo",string "testOne testTwo testtwo")
      * Output: int 1
      * Make sure to be case sensitive.
    * Input: (string "testTwo",string[] {"testOne","testTwo","testtwo"})
      * Output: int 1
      * Allows user inputing an array of strings instead of a string of words.
    * Input: (string "testTwo",string "testOne testTwo testtwo testTwo test")
      * Output: int 2
      * Wholes words only
    * Input: (string "testTwo",string "    testOne testTwo testtwo testTwo test    ")
      * Output: int 2
      * Whitespace shouldn't matter

## Requirements

Your mission is to create a program that checks how frequently a word appears in a given string. The user should input both the word and a list of words to check. Check for full word matches only.   
This week, you’ll be building out the logic and tests for this program. Next week, you will build out the UI for this program. Design your program with this in mind.

    * Before writing code, start by writing specs in English in a plain text file, just like we've been doing in class (listing them in the README is fine). Commit your English specs before beginning on your code.

    * Each spec should include a specific input and output pair, as well as a description sentence explaining why you chose that specific input value as the simplest way to test the behavior your spec is covering.

    * After you're done writing English specs, go through them one by one and translate each one into a test method for MSTest. After writing a test method and seeing it fail, make it pass. Remember to commit as you go.

    * Create a class called RepeatCounter. This class should contain logic for counting how many times a word appears in a string of words. Using more than one method could make your logic easier to test. For instance, you might have one method to test whether the user's input is valid and another for actually searching the string of words.

    * Do not use regular expressions in your logic.

    * Please be sure to name your solution folder and project folders correctly. If the folders are named incorrectly, your project will be sent back to you immediately and you will be asked to resubmit. Please use the following names:
        * Solution Name: WordCounter.Solution
        * Project Name: WordCounter
        * Test Project Name: WordCounter.Tests

    * When you view your repo on GitHub, you should see WordCounter, WordCounter.Tests, and README.md at the top level.

## License

MIT License

Copyright (c) 2018 Steven Colburn

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.
