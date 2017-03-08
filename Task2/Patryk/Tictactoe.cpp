//---------------------------------------------------------------------------

#include <vcl.h>
#pragma hdrstop

#include "Tictactoe.h"
//---------------------------------------------------------------------------
#pragma package(smart_init)
#pragma resource "*.dfm"
TForm1 *Form1;

        enum fieldOccupancyInd
        {
                clean,
                circle,
                cross
        };
        fieldOccupancyInd f1,f2,f3,f4,f5,f6,f7,f8,f9;

        enum turnInd
        {
                o,
                x
        };
        turnInd currentTurn;

        void gameCleaner(TImage *gridImage, fieldOccupancyInd &foi, TImage *cup, TLabel *infoBox){
                gridImage->Picture->LoadFromFile("img/clean.bmp");
                gridImage->Cursor=crHandPoint;
                gridImage->Enabled=true;
                infoBox->Caption="Current turn";
                cup->Visible=false;
                foi=clean;
        }

        void winnerCheck(TLabel *winnerNotification, TImage *winnerInd, TImage *cup)
        {
                if((f1==f2 && f2==f3 && f1!=clean) ||
                   (f4==f5 && f5==f6 && f4!=clean) ||
                   (f7==f8 && f8==f9 && f7!=clean) ||
                   (f1==f4 && f4==f7 && f1!=clean) ||
                   (f2==f5 && f5==f8 && f2!=clean) ||
                   (f3==f6 && f6==f9 && f3!=clean) ||
                   (f1==f5 && f5==f9 && f1!=clean) ||
                   (f3==f5 && f5==f7 && f3!=clean))
                {
                        winnerNotification->Caption="The winner is:";
                        cup->Picture->LoadFromFile("img/winner.bmp");
                        cup->Visible=true;
                        if(currentTurn==o)
                        {
                                winnerInd->Picture->LoadFromFile("img/cross_small.bmp");
                        }
                        else
                        {
                                winnerInd->Picture->LoadFromFile("img/circle_small.bmp");
                        }
                }
                else if(f1 && f2 && f3 && f4 && f5 && f6 && f7 && f8 && f9 != clean)
                {
                        winnerNotification->Caption="We have a draw";
                        winnerNotification->Left=80;
                        cup->Picture->LoadFromFile("img/draw.bmp");
                        cup->Visible=true;
                }
        }

        void move(TImage *gridImage, TImage *turnImage, fieldOccupancyInd &foi, TLabel *illegalMoveWarning, TTimer *secSleep)
        {
                if(foi==clean)
                {
                        if(currentTurn==o)
                        {
                                gridImage->Picture->LoadFromFile("img/circle.bmp");
                                currentTurn=x;
                                turnImage->Picture->LoadFromFile("img/cross_small.bmp");
                                foi=circle;
                        }
                        else
                        {
                                gridImage->Picture->LoadFromFile("img/cross.bmp");
                                currentTurn=o;
                                turnImage->Picture->LoadFromFile("img/circle_small.bmp");
                                foi=cross;
                        }
                        gridImage->Cursor=crDefault;
                }
                else
                {
                illegalMoveWarning->Visible=true;
                secSleep->Enabled=true;
                }
        }

        void freezeGrids(TImage *grid1, TImage *grid2, TImage *grid3, TImage *grid4, TImage *grid5, TImage *grid6, TImage *grid7, TImage *grid8, TImage *grid9)
        {
                grid1->Enabled=false;
                grid2->Enabled=false;
                grid3->Enabled=false;
                grid4->Enabled=false;
                grid5->Enabled=false;
                grid6->Enabled=false;
                grid7->Enabled=false;
                grid8->Enabled=false;
                grid9->Enabled=false;
        }


//---------------------------------------------------------------------------
__fastcall TForm1::TForm1(TComponent* Owner)
        : TForm(Owner)
{
}
//---------------------------------------------------------------------------

void __fastcall TForm1::FormCreate(TObject *Sender)
{
        gameCleaner(field1,f1,cup,infoBox);
        gameCleaner(field2,f2,cup,infoBox);
        gameCleaner(field3,f3,cup,infoBox);
        gameCleaner(field4,f4,cup,infoBox);
        gameCleaner(field5,f5,cup,infoBox);
        gameCleaner(field6,f6,cup,infoBox);
        gameCleaner(field7,f7,cup,infoBox);
        gameCleaner(field8,f8,cup,infoBox);
        gameCleaner(field9,f9,cup,infoBox);

        turn->Picture->LoadFromFile("img/circle_small.bmp");
        currentTurn=o;

        infoBox->Left=120;


}
//---------------------------------------------------------------------------

void __fastcall TForm1::secSleepTimer(TObject *Sender)
{
        notification->Visible=false;
        secSleep->Enabled=false;
       }
//---------------------------------------------------------------------------

void __fastcall TForm1::field1Click(TObject *Sender)
{
        move(field1, turn, f1, notification, secSleep);
        winnerCheck(infoBox, turn, cup);
        if(cup->Visible){freezeGrids(field1,field2,field3,field4,field5,field6,field7,field8,field9);}
}
//---------------------------------------------------------------------------

void __fastcall TForm1::field2Click(TObject *Sender)
{
        move(field2, turn, f2, notification, secSleep);
        winnerCheck(infoBox, turn, cup);
        if(cup->Visible){freezeGrids(field1,field2,field3,field4,field5,field6,field7,field8,field9);}
}
//---------------------------------------------------------------------------

void __fastcall TForm1::field3Click(TObject *Sender)
{
        move(field3, turn, f3, notification, secSleep);
        winnerCheck(infoBox, turn, cup);
        if(cup->Visible){freezeGrids(field1,field2,field3,field4,field5,field6,field7,field8,field9);}
}
//---------------------------------------------------------------------------

void __fastcall TForm1::field4Click(TObject *Sender)
{
        move(field4, turn, f4, notification, secSleep);
        winnerCheck(infoBox, turn, cup);
        if(cup->Visible){freezeGrids(field1,field2,field3,field4,field5,field6,field7,field8,field9);}
}
//---------------------------------------------------------------------------

void __fastcall TForm1::field5Click(TObject *Sender)
{
        move(field5, turn, f5, notification, secSleep);
        winnerCheck(infoBox, turn, cup);
        if(cup->Visible){freezeGrids(field1,field2,field3,field4,field5,field6,field7,field8,field9);}
}
//---------------------------------------------------------------------------

void __fastcall TForm1::field6Click(TObject *Sender)
{
        move(field6, turn, f6, notification, secSleep);
        winnerCheck(infoBox, turn, cup);
        if(cup->Visible){freezeGrids(field1,field2,field3,field4,field5,field6,field7,field8,field9);}
}
//---------------------------------------------------------------------------

void __fastcall TForm1::field7Click(TObject *Sender)
{
        move(field7, turn, f7, notification, secSleep);
        winnerCheck(infoBox, turn, cup);
        if(cup->Visible){freezeGrids(field1,field2,field3,field4,field5,field6,field7,field8,field9);}
}
//---------------------------------------------------------------------------

void __fastcall TForm1::field8Click(TObject *Sender)
{
        move(field8, turn, f8, notification, secSleep);
        winnerCheck(infoBox, turn, cup);
        if(cup->Visible){freezeGrids(field1,field2,field3,field4,field5,field6,field7,field8,field9);}
}
//---------------------------------------------------------------------------

void __fastcall TForm1::field9Click(TObject *Sender)
{
        move(field9, turn, f9, notification, secSleep);
        winnerCheck(infoBox, turn, cup);
        if(cup->Visible){freezeGrids(field1,field2,field3,field4,field5,field6,field7,field8,field9);}
}
//---------------------------------------------------------------------------




