grammar Sofii;

// Keywords
WITHIN: 'within';
USE: 'use';
FUNC: 'func';
METHOD: 'method';
CLASS: 'class';
CONST: 'const';
VAR: 'var';
MACRO: 'macro';
TRAIT: 'trait';
IF: 'if';
ELSE: 'else';
FOR: 'for';
IN: 'in';
WHILE: 'while';
SWITCH: 'switch';
CASE: 'case';
ENUM: 'enum';
RETURN: 'return';
GUARD: 'guard';
INIT: 'init';
WHERE: 'where';
VAL: 'val';
ONTO: 'onto';

// Operators and Punctuation
PLUS: '+';
MINUS: '-';
STAR: '*';
SLASH: '/';
MOD: '%';
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
BOW: '|}';
DOTDOT: '..';
DOTDOTDOT: '...';

// Identifiers and Literals
IDENTIFIER: [a-zA-Z_][a-zA-Z0-9_]*;
INT_LITERAL: [0-9]+;
FLOAT_LITERAL: [0-9]+'.'[0-9]*;
STRING_LITERAL: '"' .*? '"';
BOOL_LITERAL: 'true' | 'false';

// Comments
LINE_COMMENT: '//' ~[\r\n]* -> skip;
BLOCK_COMMENT: '#' .*? '#' -> skip;

// Whitespace
WS: [ \t\r\n]+ -> skip;

// Parser rules
program: within_stmt? (use_stmt | statement)*;

within_stmt: WITHIN IDENTIFIER (DOT IDENTIFIER)*;

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
    | command_call_stmt
    ;
    
block: LBRACE statement* RBRACE;
generic_params: LT type (COMMA type)* GT;

enum_def: ENUM IDENTIFIER generic_params? LBRACE enum_case* RBRACE;
enum_case: CASE IDENTIFIER (LPAREN type RPAREN)?;

trait_def: TRAIT IDENTIFIER LBRACE trait_method* RBRACE;
trait_method: METHOD IDENTIFIER LPAREN param_list? RPAREN (ARROW type)?;

class_def: CLASS IDENTIFIER (COLON IDENTIFIER (COMMA IDENTIFIER)*)? LBRACE class_body* RBRACE;
class_body: const_def | method_def | init_def | var_def | statement;

const_def: CONST IDENTIFIER (COLON type)? (ASSIGN expression)?;
var_def: VAR IDENTIFIER (COLON type)? (ASSIGN expression)?;

macro_def: MACRO IDENTIFIER generic_params? LBRACE statement* RBRACE;
func_def: FUNC IDENTIFIER LPAREN param_list? RPAREN (ARROW type)? LBRACE statement* RBRACE;
method_def: METHOD IDENTIFIER LPAREN param_list? RPAREN (ARROW type)? LBRACE statement* RBRACE;
init_def: INIT LPAREN param_list? RPAREN LBRACE statement* RBRACE;

param_list: param (COMMA param)*;
param: IDENTIFIER COLON type;

arg_list: expression (COMMA expression)*;

type: IDENTIFIER | generic_type | primitive_type | array_type;
array_type: LBRACKET primitive_type RBRACKET;
primitive_type: 'int' | 'float' | 'bool' | 'string' | 'char';
generic_type: IDENTIFIER LT type (COMMA type)* GT;

assign_stmt: (IDENTIFIER | member_access) ASSIGN expression;
command_call_stmt: command_call;
return_stmt: RETURN expression?;

if_stmt: IF expression block (ELSE block)?;
for_stmt: FOR IDENTIFIER IN expression block;
while_stmt: WHILE expression block;
switch_stmt: SWITCH expression LBRACE switch_case* RBRACE;
switch_case: CASE type IDENTIFIER (LPAREN IDENTIFIER RPAREN)? block;

guard_stmt: GUARD expression block;

interpolated_string: STRING_LITERAL (LBRACE expression RBRACE)*;

clause: map_clause | where_clause | range_clause;
map_clause: (IDENTIFIER | array_literal) ONTO array_literal;
where_clause: (IDENTIFIER | array_literal) WHERE array_literal;
range_clause: LPAREN expression ARROW expression RPAREN;
     
expression: primary (operator primary)*;
primary: command_call | member_access | literal | interpolated_string | clause;

literal: IDENTIFIER | VAL | INT_LITERAL | FLOAT_LITERAL | STRING_LITERAL | BOOL_LITERAL | array_literal;
array_literal: LBRACKET (expression (COMMA expression)*)? RBRACKET;

command_call: func_call | method_call | macro_call;
method_call: member_access LPAREN arg_list? RPAREN;
func_call: IDENTIFIER LPAREN arg_list? RPAREN;
macro_call: IDENTIFIER ARROW LPAREN arg_list? RPAREN;

member_access: IDENTIFIER (DOT IDENTIFIER)+;

operator: PLUS | MINUS | STAR | SLASH | EQUAL | NOTEQUAL | LT | GT | LTE | GTE | AND | OR | NOT | MOD;
