#!/usr/bin/env bash
cd ..
dotnet restore ./WordCounter
dotnet build ./WordCounter
dotnet restore ./WordCounter.Tests/
