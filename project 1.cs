﻿//Generated by the GOLD Parser Builder

using System.IO;
using System.Windows.Forms;

class MyParser
{
    private GOLD.Parser parser = new GOLD.Parser(); 

    private enum SymbolIndex
    {
        @Eof = 0,                                  // (EOF)
        @Error = 1,                                // (Error)
        @Comment = 2,                              // Comment
        @Newline = 3,                              // NewLine
        @Whitespace = 4,                           // Whitespace
        @Timesdiv = 5,                             // '*/'
        @Divtimes = 6,                             // '/*'
        @Divdiv = 7,                               // '//'
        @Minus = 8,                                // '-'
        @Exclameq = 9,                             // '!='
        @Quote = 10,                               // '"'
        @Lparen = 11,                              // '('
        @Rparen = 12,                              // ')'
        @Comma = 13,                               // ','
        @Colon = 14,                               // ':'
        @Coloneq = 15,                             // ':='
        @Semi = 16,                                // ';'
        @Lbrace = 17,                              // '{'
        @Pipepipe = 18,                            // '||'
        @Rbrace = 19,                              // '}'
        @Plus = 20,                                // '+'
        @Lt = 21,                                  // '<'
        @Lteq = 22,                                // '<='
        @Eq = 23,                                  // '='
        @Eqeq = 24,                                // '=='
        @Gt = 25,                                  // '>'
        @Gteq = 26,                                // '>='
        @Begin = 27,                               // begin
        @Declare = 28,                             // declare
        @Digit = 29,                               // digit
        @Do = 30,                                  // do
        @Else = 31,                                // else
        @End = 32,                                 // end
        @Fi = 33,                                  // fi
        @Floatliteral = 34,                        // FloatLiteral
        @For = 35,                                 // for
        @If = 36,                                  // if
        @Letter = 37,                              // letter
        @Natural = 38,                             // natural
        @Od = 39,                                  // od
        @String = 40,                              // string
        @Stringliteral = 41,                       // StringLiteral
        @Then = 42,                                // then
        @To = 43,                                  // to
        @While = 44,                               // while
        @Anyminuscharminusbutminusquote = 45,      // <any-char-but-quote>
        @Assign = 46,                              // <assign>
        @Conc = 47,                                // <conc>
        @Decls = 48,                               // <decls>
        @Digit2 = 49,                              // <digit>
        @Digits = 50,                              // <digits>
        @Empty = 51,                               // <empty>
        @Exp = 52,                                 // <exp>
        @For2 = 53,                                // <for>
        @Function = 54,                            // <function>
        @Functiondef = 55,                         // <functiondef>
        @Id = 56,                                  // <id>
        @Idminuschar1 = 57,                        // <id-char1>
        @Idminustypeminuslist = 58,                // <id-type-list>
        @If2 = 59,                                 // <if>
        @Ife = 60,                                 // <ife>
        @Letter2 = 61,                             // <letter>
        @Letters = 62,                             // <letters>
        @Literal = 63,                             // <literal>
        @Minus2 = 64,                              // <minus>
        @Naturalminusconstant = 65,                // <natural-constant>
        @Parameterlist = 66,                       // <parameterList>
        @Parameterlist1 = 67,                      // <parameterList1>
        @Parameters = 68,                          // <parameters>
        @Parametersdef = 69,                       // <parametersdef>
        @Picominusprogram = 70,                    // <pico-program>
        @Plus2 = 71,                               // <plus>
        @Primary = 72,                             // <primary>
        @Program = 73,                             // <Program>
        @Quote2 = 74,                              // <quote>
        @Rel_op = 75,                              // <rel_op>
        @Series = 76,                              // <series>
        @Stat = 77,                                // <stat>
        @Stringminusconstant = 78,                 // <string-constant>
        @Stringminustail = 79,                     // <string-tail>
        @Type = 80,                                // <type>
        @While2 = 81                               // <while>
    }

    private enum ProductionIndex
    {
        @Picoprogram_Begin_End = 0,                // <pico-program> ::= begin <decls> <series> end
        @Picoprogram_Begin_End2 = 1,               // <pico-program> ::= begin <decls> <functiondef> end
        @Picoprogram_Begin_End3 = 2,               // <pico-program> ::= begin <decls> <functiondef> <function> end
        @Decls_Declare_Semi = 3,                   // <decls> ::= declare <id-type-list> ';'
        @Idtypelist_Colon = 4,                     // <id-type-list> ::= <id> ':' <type> <empty>
        @Idtypelist_Colon_Comma = 5,               // <id-type-list> ::= <id> ':' <type> ',' <id-type-list>
        @Type_Natural = 6,                         // <type> ::= natural
        @Type_String = 7,                          // <type> ::= string
        @Series = 8,                               // <series> ::= <empty>
        @Series2 = 9,                              // <series> ::= <stat> <empty>
        @Series_Semi = 10,                         // <series> ::= <stat> ';' <series>
        @Stat = 11,                                // <stat> ::= <assign>
        @Stat2 = 12,                               // <stat> ::= <if>
        @Stat3 = 13,                               // <stat> ::= <while>
        @Stat4 = 14,                               // <stat> ::= <ife>
        @Stat5 = 15,                               // <stat> ::= <for>
        @Assign_Coloneq = 16,                      // <assign> ::= <id> ':=' <exp>
        @If_If_Then_Else_Fi = 17,                  // <if> ::= if <exp> then <series> else <series> fi
        @While_While_Do_Od = 18,                   // <while> ::= while <exp> do <series> od
        @Ife_If_Then_Fi = 19,                      // <ife> ::= if <exp> then <series> fi
        @For_For_Eq_To_Lbrace_Rbrace = 20,         // <for> ::= for <id> '=' <natural-constant> to <natural-constant> '{' <series> '}'
        @Exp = 21,                                 // <exp> ::= <primary>
        @Exp2 = 22,                                // <exp> ::= <plus>
        @Exp3 = 23,                                // <exp> ::= <minus>
        @Exp4 = 24,                                // <exp> ::= <conc>
        @Exp5 = 25,                                // <exp> ::= <rel_op>
        @Primary = 26,                             // <primary> ::= <id>
        @Primary2 = 27,                            // <primary> ::= <natural-constant>
        @Primary3 = 28,                            // <primary> ::= <string-constant>
        @Primary_Lparen_Rparen = 29,               // <primary> ::= '(' <exp> ')'
        @Plus_Plus = 30,                           // <plus> ::= <exp> '+' <primary>
        @Minus_Minus = 31,                         // <minus> ::= <exp> '-' <primary>
        @Conc_Pipepipe = 32,                       // <conc> ::= <exp> '||' <primary>
        @Rel_op_Eqeq = 33,                         // <rel_op> ::= <exp> '==' <primary>
        @Rel_op_Eq = 34,                           // <rel_op> ::= <exp> '=' <primary>
        @Rel_op_Exclameq = 35,                     // <rel_op> ::= <exp> '!=' <primary>
        @Rel_op_Lt = 36,                           // <rel_op> ::= <exp> '<' <primary>
        @Rel_op_Lteq = 37,                         // <rel_op> ::= <exp> '<=' <primary>
        @Rel_op_Gt = 38,                           // <rel_op> ::= <exp> '>' <primary>
        @Rel_op_Gteq = 39,                         // <rel_op> ::= <exp> '>=' <primary>
        @Empty = 40,                               // <empty> ::= 
        @Id = 41,                                  // <id> ::= <letter> <id-char1>
        @Idchar1 = 42,                             // <id-char1> ::= <letter> <id-char1>
        @Idchar12 = 43,                            // <id-char1> ::= <digit> <id-char1>
        @Idchar13 = 44,                            // <id-char1> ::= <empty>
        @Naturalconstant = 45,                     // <natural-constant> ::= <digit> <digits>
        @Digits = 46,                              // <digits> ::= <digit> <digits>
        @Digits2 = 47,                             // <digits> ::= <empty>
        @Letters = 48,                             // <letters> ::= <letter> <letters>
        @Letters2 = 49,                            // <letters> ::= <empty>
        @Stringconstant = 50,                      // <string-constant> ::= <quote> <string-tail>
        @Stringtail = 51,                          // <string-tail> ::= <any-char-but-quote> <string-tail>
        @Stringtail2 = 52,                         // <string-tail> ::= <quote>
        @Quote_Quote = 53,                         // <quote> ::= '"'
        @Anycharbutquote = 54,                     // <any-char-but-quote> ::= <letter>
        @Anycharbutquote2 = 55,                    // <any-char-but-quote> ::= <digit>
        @Anycharbutquote3 = 56,                    // <any-char-but-quote> ::= <literal>
        @Literal_Lparen = 57,                      // <literal> ::= '('
        @Literal_Rparen = 58,                      // <literal> ::= ')'
        @Literal_Plus = 59,                        // <literal> ::= '+'
        @Literal_Minus = 60,                       // <literal> ::= '-'
        @Literal_Semi = 61,                        // <literal> ::= ';'
        @Literal_Pipepipe = 62,                    // <literal> ::= '||'
        @Literal_Colon = 63,                       // <literal> ::= ':'
        @Literal_Coloneq = 64,                     // <literal> ::= ':='
        @Letter_Letter = 65,                       // <letter> ::= letter
        @Digit_Digit = 66,                         // <digit> ::= digit
        @Functiondef_Colon_End = 67,               // <functiondef> ::= <id> <parametersdef> ':' <series> end
        @Parametersdef_Lparen_Rparen = 68,         // <parametersdef> ::= '(' <parameterList> ')'
        @Parameterlist_Comma = 69,                 // <parameterList> ::= <id> ',' <parameterList>
        @Parameterlist = 70,                       // <parameterList> ::= <id>
        @Parameterlist2 = 71,                      // <parameterList> ::= <empty>
        @Function = 72,                            // <function> ::= <id> <parameters>
        @Parameters_Lparen_Rparen = 73,            // <parameters> ::= '(' <parameterList1> ')'
        @Parameterlist1_Comma = 74,                // <parameterList1> ::= <id> ',' <parameterList1>
        @Parameterlist1 = 75,                      // <parameterList1> ::= <id>
        @Parameterlist1_Comma2 = 76,               // <parameterList1> ::= <natural-constant> ',' <parameterList1>
        @Parameterlist12 = 77,                     // <parameterList1> ::= <natural-constant>
        @Parameterlist13 = 78,                     // <parameterList1> ::= <empty>
        @Program = 79                              // <Program> ::= <pico-program>
    }

    public object program;     //You might derive a specific object

    public void Setup()
    {
        //This procedure can be called to load the parse tables. The class can
        //read tables using a BinaryReader.
        
        parser.LoadTables(Path.Combine(Application.StartupPath, "grammar.egt"));
    }
    
    public bool Parse(TextReader reader)
    {
        //This procedure starts the GOLD Parser Engine and handles each of the
        //messages it returns. Each time a reduction is made, you can create new
        //custom object and reassign the .CurrentReduction property. Otherwise, 
        //the system will use the Reduction object that was returned.
        //
        //The resulting tree will be a pure representation of the language 
        //and will be ready to implement.

        GOLD.ParseMessage response; 
        bool done;                      //Controls when we leave the loop
        bool accepted = false;          //Was the parse successful?

        parser.Open(reader);
        parser.TrimReductions = false;  //Please read about this feature before enabling  

        done = false;
        while (!done)
        {
            response = parser.Parse();

            switch (response)
            {
                case GOLD.ParseMessage.LexicalError:
                    //Cannot recognize token
                    done = true;
                    break;

                case GOLD.ParseMessage.SyntaxError:
                    //Expecting a different token
                    done = true;
                    break;

                case GOLD.ParseMessage.Reduction:
                    //Create a customized object to store the reduction

                    parser.CurrentReduction = CreateNewObject(parser.CurrentReduction as GOLD.Reduction);
                    break;

                case GOLD.ParseMessage.Accept:
                    //Accepted!
                    //program = parser.CurrentReduction   //The root node!                 
                    done = true;
                    accepted = true;
                    break;

                case GOLD.ParseMessage.TokenRead:
                    //You don't have to do anything here.
                    break;

                case GOLD.ParseMessage.InternalError:
                    //INTERNAL ERROR! Something is horribly wrong.
                    done = true;
                    break;

                case GOLD.ParseMessage.NotLoadedError:
                    //This error occurs if the CGT was not loaded.                   
                    done = true;
                    break;

                case GOLD.ParseMessage.GroupError: 
                    //GROUP ERROR! Unexpected end of file
                    done = true;
                    break;
            } 
        } //while

        return accepted;
    }
    
    private object CreateNewObject(GOLD.Reduction r)
    { 
        object result = null;
        
        switch( (ProductionIndex) r.Parent.TableIndex)
        {
            case ProductionIndex.Picoprogram_Begin_End:                 
                // <pico-program> ::= begin <decls> <series> end
                break;

            case ProductionIndex.Picoprogram_Begin_End2:                 
                // <pico-program> ::= begin <decls> <functiondef> end
                break;

            case ProductionIndex.Picoprogram_Begin_End3:                 
                // <pico-program> ::= begin <decls> <functiondef> <function> end
                break;

            case ProductionIndex.Decls_Declare_Semi:                 
                // <decls> ::= declare <id-type-list> ';'
                break;

            case ProductionIndex.Idtypelist_Colon:                 
                // <id-type-list> ::= <id> ':' <type> <empty>
                break;

            case ProductionIndex.Idtypelist_Colon_Comma:                 
                // <id-type-list> ::= <id> ':' <type> ',' <id-type-list>
                break;

            case ProductionIndex.Type_Natural:                 
                // <type> ::= natural
                break;

            case ProductionIndex.Type_String:                 
                // <type> ::= string
                break;

            case ProductionIndex.Series:                 
                // <series> ::= <empty>
                break;

            case ProductionIndex.Series2:                 
                // <series> ::= <stat> <empty>
                break;

            case ProductionIndex.Series_Semi:                 
                // <series> ::= <stat> ';' <series>
                break;

            case ProductionIndex.Stat:                 
                // <stat> ::= <assign>
                break;

            case ProductionIndex.Stat2:                 
                // <stat> ::= <if>
                break;

            case ProductionIndex.Stat3:                 
                // <stat> ::= <while>
                break;

            case ProductionIndex.Stat4:                 
                // <stat> ::= <ife>
                break;

            case ProductionIndex.Stat5:                 
                // <stat> ::= <for>
                break;

            case ProductionIndex.Assign_Coloneq:                 
                // <assign> ::= <id> ':=' <exp>
                break;

            case ProductionIndex.If_If_Then_Else_Fi:                 
                // <if> ::= if <exp> then <series> else <series> fi
                break;

            case ProductionIndex.While_While_Do_Od:                 
                // <while> ::= while <exp> do <series> od
                break;

            case ProductionIndex.Ife_If_Then_Fi:                 
                // <ife> ::= if <exp> then <series> fi
                break;

            case ProductionIndex.For_For_Eq_To_Lbrace_Rbrace:                 
                // <for> ::= for <id> '=' <natural-constant> to <natural-constant> '{' <series> '}'
                break;

            case ProductionIndex.Exp:                 
                // <exp> ::= <primary>
                break;

            case ProductionIndex.Exp2:                 
                // <exp> ::= <plus>
                break;

            case ProductionIndex.Exp3:                 
                // <exp> ::= <minus>
                break;

            case ProductionIndex.Exp4:                 
                // <exp> ::= <conc>
                break;

            case ProductionIndex.Exp5:                 
                // <exp> ::= <rel_op>
                break;

            case ProductionIndex.Primary:                 
                // <primary> ::= <id>
                break;

            case ProductionIndex.Primary2:                 
                // <primary> ::= <natural-constant>
                break;

            case ProductionIndex.Primary3:                 
                // <primary> ::= <string-constant>
                break;

            case ProductionIndex.Primary_Lparen_Rparen:                 
                // <primary> ::= '(' <exp> ')'
                break;

            case ProductionIndex.Plus_Plus:                 
                // <plus> ::= <exp> '+' <primary>
                break;

            case ProductionIndex.Minus_Minus:                 
                // <minus> ::= <exp> '-' <primary>
                break;

            case ProductionIndex.Conc_Pipepipe:                 
                // <conc> ::= <exp> '||' <primary>
                break;

            case ProductionIndex.Rel_op_Eqeq:                 
                // <rel_op> ::= <exp> '==' <primary>
                break;

            case ProductionIndex.Rel_op_Eq:                 
                // <rel_op> ::= <exp> '=' <primary>
                break;

            case ProductionIndex.Rel_op_Exclameq:                 
                // <rel_op> ::= <exp> '!=' <primary>
                break;

            case ProductionIndex.Rel_op_Lt:                 
                // <rel_op> ::= <exp> '<' <primary>
                break;

            case ProductionIndex.Rel_op_Lteq:                 
                // <rel_op> ::= <exp> '<=' <primary>
                break;

            case ProductionIndex.Rel_op_Gt:                 
                // <rel_op> ::= <exp> '>' <primary>
                break;

            case ProductionIndex.Rel_op_Gteq:                 
                // <rel_op> ::= <exp> '>=' <primary>
                break;

            case ProductionIndex.Empty:                 
                // <empty> ::= 
                break;

            case ProductionIndex.Id:                 
                // <id> ::= <letter> <id-char1>
                break;

            case ProductionIndex.Idchar1:                 
                // <id-char1> ::= <letter> <id-char1>
                break;

            case ProductionIndex.Idchar12:                 
                // <id-char1> ::= <digit> <id-char1>
                break;

            case ProductionIndex.Idchar13:                 
                // <id-char1> ::= <empty>
                break;

            case ProductionIndex.Naturalconstant:                 
                // <natural-constant> ::= <digit> <digits>
                break;

            case ProductionIndex.Digits:                 
                // <digits> ::= <digit> <digits>
                break;

            case ProductionIndex.Digits2:                 
                // <digits> ::= <empty>
                break;

            case ProductionIndex.Letters:                 
                // <letters> ::= <letter> <letters>
                break;

            case ProductionIndex.Letters2:                 
                // <letters> ::= <empty>
                break;

            case ProductionIndex.Stringconstant:                 
                // <string-constant> ::= <quote> <string-tail>
                break;

            case ProductionIndex.Stringtail:                 
                // <string-tail> ::= <any-char-but-quote> <string-tail>
                break;

            case ProductionIndex.Stringtail2:                 
                // <string-tail> ::= <quote>
                break;

            case ProductionIndex.Quote_Quote:                 
                // <quote> ::= '"'
                break;

            case ProductionIndex.Anycharbutquote:                 
                // <any-char-but-quote> ::= <letter>
                break;

            case ProductionIndex.Anycharbutquote2:                 
                // <any-char-but-quote> ::= <digit>
                break;

            case ProductionIndex.Anycharbutquote3:                 
                // <any-char-but-quote> ::= <literal>
                break;

            case ProductionIndex.Literal_Lparen:                 
                // <literal> ::= '('
                break;

            case ProductionIndex.Literal_Rparen:                 
                // <literal> ::= ')'
                break;

            case ProductionIndex.Literal_Plus:                 
                // <literal> ::= '+'
                break;

            case ProductionIndex.Literal_Minus:                 
                // <literal> ::= '-'
                break;

            case ProductionIndex.Literal_Semi:                 
                // <literal> ::= ';'
                break;

            case ProductionIndex.Literal_Pipepipe:                 
                // <literal> ::= '||'
                break;

            case ProductionIndex.Literal_Colon:                 
                // <literal> ::= ':'
                break;

            case ProductionIndex.Literal_Coloneq:                 
                // <literal> ::= ':='
                break;

            case ProductionIndex.Letter_Letter:                 
                // <letter> ::= letter
                break;

            case ProductionIndex.Digit_Digit:                 
                // <digit> ::= digit
                break;

            case ProductionIndex.Functiondef_Colon_End:                 
                // <functiondef> ::= <id> <parametersdef> ':' <series> end
                break;

            case ProductionIndex.Parametersdef_Lparen_Rparen:                 
                // <parametersdef> ::= '(' <parameterList> ')'
                break;

            case ProductionIndex.Parameterlist_Comma:                 
                // <parameterList> ::= <id> ',' <parameterList>
                break;

            case ProductionIndex.Parameterlist:                 
                // <parameterList> ::= <id>
                break;

            case ProductionIndex.Parameterlist2:                 
                // <parameterList> ::= <empty>
                break;

            case ProductionIndex.Function:                 
                // <function> ::= <id> <parameters>
                break;

            case ProductionIndex.Parameters_Lparen_Rparen:                 
                // <parameters> ::= '(' <parameterList1> ')'
                break;

            case ProductionIndex.Parameterlist1_Comma:                 
                // <parameterList1> ::= <id> ',' <parameterList1>
                break;

            case ProductionIndex.Parameterlist1:                 
                // <parameterList1> ::= <id>
                break;

            case ProductionIndex.Parameterlist1_Comma2:                 
                // <parameterList1> ::= <natural-constant> ',' <parameterList1>
                break;

            case ProductionIndex.Parameterlist12:                 
                // <parameterList1> ::= <natural-constant>
                break;

            case ProductionIndex.Parameterlist13:                 
                // <parameterList1> ::= <empty>
                break;

            case ProductionIndex.Program:                 
                // <Program> ::= <pico-program>
                break;

        }  //switch

        return result;
    }
    
}; //MyParser