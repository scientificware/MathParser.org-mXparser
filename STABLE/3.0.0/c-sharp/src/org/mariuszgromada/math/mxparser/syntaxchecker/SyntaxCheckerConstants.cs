/* Generated By:CSharpCC: Do not edit this line. SyntaxCheckerConstants.cs */
namespace org.mariuszgromada.math.mxparser.syntaxchecker{
public class SyntaxCheckerConstants {
  internal const int EOF = 0;
  internal const int LETTER = 5;
  internal const int DIGIT = 6;
  internal const int LETTERS = 7;
  internal const int INTEGER = 8;
  internal const int LEFT_PAR = 9;
  internal const int RIGHT_PAR = 10;
  internal const int PLUS = 11;
  internal const int MINUS = 12;
  internal const int MULTIPLY = 13;
  internal const int DIV = 14;
  internal const int POWER = 15;
  internal const int MODULO = 16;
  internal const int FACTORIAL = 17;
  internal const int COMMA = 18;
  internal const int SEMICOLON = 19;
  internal const int EQ = 20;
  internal const int NEQ = 21;
  internal const int LT = 22;
  internal const int LEQ = 23;
  internal const int GT = 24;
  internal const int GEQ = 25;
  internal const int OR = 26;
  internal const int AND = 27;
  internal const int NOT = 28;
  internal const int IMP = 29;
  internal const int CIMP = 30;
  internal const int NIMP = 31;
  internal const int CNIMP = 32;
  internal const int NAND = 33;
  internal const int EQV = 34;
  internal const int NOR = 35;
  internal const int XOR = 36;
  internal const int CHAR = 37;
  internal const int REAL = 38;
  internal const int IDENTIFIER = 39;
  internal const int FUNCTION = 40;
  internal const int INVALID_TOKEN = 43;
  internal const int UNEXPECTED_CHAR = 44;
  internal const int DEFAULT = 0;
  internal readonly string[] tokenImage = {
    "<EOF>",
    "\" \"",
    "\"\\t\"",
    "\"\\n\"",
    "\"\\r\"",
    "<LETTER>",
    "<DIGIT>",
    "<LETTERS>",
    "<INTEGER>",
    "\"(\"",
    "\")\"",
    "\"+\"",
    "\"-\"",
    "\"*\"",
    "\"/\"",
    "\"^\"",
    "\"%\"",
    "\"!\"",
    "\",\"",
    "\";\"",
    "<EQ>",
    "<NEQ>",
    "\"<\"",
    "\"<=\"",
    "\">\"",
    "\">=\"",
    "<OR>",
    "<AND>",
    "\"~\"",
    "<IMP>",
    "<CIMP>",
    "<NIMP>",
    "<CNIMP>",
    "<NAND>",
    "<EQV>",
    "<NOR>",
    "<XOR>",
    "<CHAR>",
    "<REAL>",
    "<IDENTIFIER>",
    "<FUNCTION>",
    "\"[\"",
    "\"]\"",
    "<INVALID_TOKEN>",
    "<UNEXPECTED_CHAR>",
  };
}
}