grammar Sofii;

// Keywords
WITHIN: 'within';
USE: 'use';
FUNC: 'func';
CLASS: 'class';
CONST: 'const';
VAR: 'var';
MACRO: 'macro';
TRAIT: 'trait';
IF: 'if';
ELSE: 'else';
FOR: 'for';
WHILE: 'while';
SWITCH: 'switch';
CASE: 'case';
ENUM: 'enum';
RETURN: 'return';
GUARD: 'guard';
INIT: 'init';

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
AND: '&';
OR: '|';
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
    use_stmt
    | enum_def
    | trait_def
    | class_def
    | func_def
    | init_def
    | macro_def
    | var_def
    | const_def
    | assign_stmt
    | return_stmt
    | if_stmt
    | for_stmt
    | while_stmt
    | switch_stmt
    | guard_stmt
    | expression_stmt
    ;

enum_def: ENUM IDENTIFIER generic_params? LBRACE enum_case* RBRACE;
generic_params: LT type (COMMA type)* GT;

enum_case: CASE IDENTIFIER (LPAREN type RPAREN)?;

trait_def: TRAIT IDENTIFIER LBRACE trait_method* RBRACE;
trait_method: FUNC IDENTIFIER LPAREN param_list? RPAREN (ARROW type)?;

class_def: CLASS IDENTIFIER (':' IDENTIFIER)? LBRACE class_body* RBRACE;

class_body: const_def | func_def | init_def | var_def | statement;

const_def: CONST IDENTIFIER (COLON type)? (ASSIGN expression)?;
var_def: VAR IDENTIFIER (COLON type)? (ASSIGN expression)?;

macro_def: MACRO IDENTIFIER generic_params LBRACE statement* RBRACE;

func_def: FUNC IDENTIFIER LPAREN param_list? RPAREN (ARROW type)? LBRACE statement* RBRACE;

init_def: INIT LPAREN param_list? RPAREN LBRACE statement* RBRACE;

param_list: param (COMMA param)*;
param: IDENTIFIER COLON type;

type: IDENTIFIER | generic_type;
generic_type: IDENTIFIER LT type (COMMA type)* GT;

assign_stmt: (IDENTIFIER | member_access) ASSIGN expression;

return_stmt: RETURN expression?;

if_stmt: IF expression block (ELSE block)?;

for_stmt: FOR IDENTIFIER IN expression block;

while_stmt: WHILE expression block;

switch_stmt: SWITCH expression LBRACE switch_case* RBRACE;
switch_case: CASE IDENTIFIER LPAREN IDENTIFIER RPAREN block;

guard_stmt: GUARD expression block;

lambda_expression: LBRACE param COLON type ARROW expression RBRACE;

// TODO - improve interpolation flexibility
interpolated_string: STRING_LITERAL (LBRACE expression RBRACE)*;

block: LBRACE statement* RBRACE;

expression_stmt: expression;

expression: primary (operator primary)*;
primary: IDENTIFIER | INT_LITERAL | FLOAT_LITERAL | STRING_LITERAL | BOOL_LITERAL | command_call | member_access | interpolated_string;

command_call: func_call | method_call | macro_call | object_creation;
method_call : member_access LPAREN (expression (COMMA expression)*)? RPAREN;
func_call: IDENTIFIER LPAREN (expression (COMMA expression)*)? RPAREN;
macro_call: IDENTIFIER ARROW LPAREN (expression (COMMA expression)*)? RPAREN;
object_creation: IDENTIFIER LPAREN (expression (COMMA expression)*)? RPAREN;

member_access: IDENTIFIER (DOT IDENTIFIER)+;

operator: PLUS | MINUS | STAR | SLASH | EQUAL | NOTEQUAL | LT | GT | LTE | GTE | AND | OR | NOT;
