#!/bin/bash

if [ "$#" -ne 1 ]; then
    echo "Usage: sh antlr-py.sh <grammar-file>"
    exit 1
fi

GRAMMAR_FILE=$1

# Check if the ANTLR jar file exists
if [ ! -f "antlr4.jar" ]; then
    echo "antlr 4 .jar not found! Please download it from https://www.antlr.org/download.html"
    exit 1
fi

# Run ANTLR tool
java -jar antlr4.jar -Dlanguage=CSharp "$GRAMMAR_FILE"

if [ $? -eq 0 ]; then
    mv *.cs ./SofiiLang
    mv *.interp ./SofiiLang
    mv *.tokens ./SofiiLang
    echo "Lexer and parser generated successfully."
else
    echo "Failed to generate lexer and parser."
    exit 1
fi
