grammar Sofii;

// Keywords
WITHIN: 'within';
USE: 'use';
FUNC: 'func';
CLASS: 'class';
CONST: 'const';
VAR: 'var';
MACRO: 'macro';
TRAITS: 'traits';
IF: 'if';
ELSE: 'else';
FOR: 'for';
WHILE: 'while';
SWITCH: 'switch';
CASE: 'case';
ENUM: 'enum';
RETURN: 'return';
GUARD: 'guard';

// Operators and Punctuation
PLUS: '+';
MINUS: '-';
STAR: '*';
SLASH: '/';
ASSIGN: '=';
EQUAL: '==';
NOTEQUAL: '!=';
LT: '<';
GT: '>';
LTE: '<=';
GTE: '>=';
AND: '&&';
OR: '||';
NOT: '!';
LPAREN: '(';
RPAREN: ')';
LBRACE: '{';
RBRACE: '}';
LBRACKET: '[';
RBRACKET: ']';
SEMICOLON: ';';
COLON: ':';
COMMA: ',';
DOT: '.';
ARROW: '->';
IN: 'in';

// Identifiers and Literals
IDENTIFIER: [a-zA-Z_][a-zA-Z0-9_]*;
INT_LITERAL: [0-9]+;
FLOAT_LITERAL: [0-9]+'.'[0-9]*;
STRING_LITERAL: '"' .*? '"';
BOOL_LITERAL: 'true' | 'false';

// Comments
LINE_COMMENT: '//' ~[\r\n]* -> skip;
BLOCK_COMMENT: '/*' .*? '*/' -> skip;

// Whitespace
WS: [ \t\r\n]+ -> skip;

// Parser rules
program: (use_stmt | within_stmt | statement)*;

within_stmt: WITHIN IDENTIFIER statement*;

use_stmt: USE IDENTIFIER (DOT IDENTIFIER)*;

statement: 
    enum_def
    | traits_def
    | class_def
    | func_def
    | macro_def
    | var_def
    | assign_stmt
    | return_stmt
    | if_stmt
    | for_stmt
    | while_stmt
    | switch_stmt
    | expression_stmt
    ;

enum_def: ENUM IDENTIFIER LBRACE enum_case* RBRACE;

enum_case: CASE IDENTIFIER LPAREN type RPAREN;

traits_def: TRAITS IDENTIFIER LBRACE func_def* RBRACE;

class_def: CLASS IDENTIFIER (':' IDENTIFIER)? LBRACE (const_def | func_def)* RBRACE;

const_def: CONST IDENTIFIER COLON type ASSIGN expression SEMICOLON;

macro_def: MACRO IDENTIFIER LT IDENTIFIER GT LBRACE statement* RBRACE;

func_def: FUNC IDENTIFIER LPAREN param_list? RPAREN (ARROW type)? LBRACE statement* RBRACE;

param_list: param (COMMA param)*;
param: IDENTIFIER COLON type;

type: IDENTIFIER;

var_def: VAR IDENTIFIER COLON type ASSIGN expression SEMICOLON;

assign_stmt: IDENTIFIER ASSIGN expression SEMICOLON;

return_stmt: RETURN expression? SEMICOLON;

if_stmt: IF expression block (ELSE block)?;

for_stmt: FOR IDENTIFIER IN expression block;

while_stmt: WHILE expression block;

switch_stmt: SWITCH expression LBRACE switch_case* RBRACE;
switch_case: CASE expression COLON block;

block: LBRACE statement* RBRACE;

expression_stmt: expression;

expression: primary (operator primary)*;
primary: IDENTIFIER | INT_LITERAL | FLOAT_LITERAL | STRING_LITERAL | BOOL_LITERAL | func_call;
func_call: IDENTIFIER LPAREN (expression (COMMA expression)*)? RPAREN;

operator: PLUS | MINUS | STAR | SLASH | EQUAL | NOTEQUAL | LT | GT | LTE | GTE | AND | OR | NOT;
