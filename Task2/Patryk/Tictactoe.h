//---------------------------------------------------------------------------

#ifndef TictactoeH
#define TictactoeH
//---------------------------------------------------------------------------
#include <Classes.hpp>
#include <Controls.hpp>
#include <StdCtrls.hpp>
#include <Forms.hpp>
#include <ExtCtrls.hpp>
//---------------------------------------------------------------------------
class TForm1 : public TForm
{
__published:	// IDE-managed Components
        TImage *field1;
        TImage *field2;
        TImage *field3;
        TImage *field6;
        TImage *field4;
        TImage *field9;
        TImage *field7;
        TImage *field5;
        TImage *field8;
        TLabel *infoBox;
        TImage *turn;
        TButton *Button1;
        TLabel *notification;
        TTimer *secSleep;
        TImage *cup;
        void __fastcall FormCreate(TObject *Sender);
        void __fastcall secSleepTimer(TObject *Sender);
        void __fastcall field1Click(TObject *Sender);
        void __fastcall field2Click(TObject *Sender);
        void __fastcall field3Click(TObject *Sender);
        void __fastcall field4Click(TObject *Sender);
        void __fastcall field5Click(TObject *Sender);
        void __fastcall field6Click(TObject *Sender);
        void __fastcall field7Click(TObject *Sender);
        void __fastcall field8Click(TObject *Sender);
        void __fastcall field9Click(TObject *Sender);
private:	// User declarations
public:		// User declarations
        __fastcall TForm1(TComponent* Owner);
};
//---------------------------------------------------------------------------
extern PACKAGE TForm1 *Form1;
//---------------------------------------------------------------------------
#endif
