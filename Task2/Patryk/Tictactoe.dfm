object Form1: TForm1
  Left = 907
  Top = 21
  Width = 500
  Height = 700
  Caption = 'TicTacToe'
  Color = clBtnFace
  Font.Charset = DEFAULT_CHARSET
  Font.Color = clWindowText
  Font.Height = -11
  Font.Name = 'MS Sans Serif'
  Font.Style = []
  OldCreateOrder = False
  OnCreate = FormCreate
  PixelsPerInch = 96
  TextHeight = 13
  object field1: TImage
    Left = 88
    Top = 168
    Width = 100
    Height = 100
    Cursor = crHandPoint
    OnClick = field1Click
  end
  object field2: TImage
    Left = 192
    Top = 168
    Width = 100
    Height = 100
    Cursor = crHandPoint
    OnClick = field2Click
  end
  object field3: TImage
    Left = 296
    Top = 168
    Width = 100
    Height = 100
    Cursor = crHandPoint
    OnClick = field3Click
  end
  object field6: TImage
    Left = 296
    Top = 272
    Width = 100
    Height = 100
    Cursor = crHandPoint
    OnClick = field6Click
  end
  object field4: TImage
    Left = 88
    Top = 272
    Width = 100
    Height = 100
    Cursor = crHandPoint
    OnClick = field4Click
  end
  object field9: TImage
    Left = 296
    Top = 376
    Width = 100
    Height = 100
    Cursor = crHandPoint
    OnClick = field9Click
  end
  object field7: TImage
    Left = 88
    Top = 376
    Width = 100
    Height = 100
    Cursor = crHandPoint
    OnClick = field7Click
  end
  object field5: TImage
    Left = 192
    Top = 272
    Width = 100
    Height = 100
    Cursor = crHandPoint
    OnClick = field5Click
  end
  object field8: TImage
    Left = 192
    Top = 376
    Width = 100
    Height = 100
    Cursor = crHandPoint
    OnClick = field8Click
  end
  object infoBox: TLabel
    Left = 120
    Top = 88
    Width = 161
    Height = 39
    Caption = 'Current turn'
    Color = clBtnFace
    Font.Charset = EASTEUROPE_CHARSET
    Font.Color = clBlack
    Font.Height = -32
    Font.Name = 'Impact'
    Font.Style = []
    ParentColor = False
    ParentFont = False
  end
  object turn: TImage
    Left = 304
    Top = 88
    Width = 35
    Height = 35
  end
  object notification: TLabel
    Left = 112
    Top = 488
    Width = 258
    Height = 16
    Caption = 'Illegal move! Please select unoccupied field.'
    Font.Charset = EASTEUROPE_CHARSET
    Font.Color = clRed
    Font.Height = -13
    Font.Name = 'Arial'
    Font.Style = [fsItalic]
    ParentFont = False
    Visible = False
  end
  object cup: TImage
    Left = 352
    Top = 40
    Width = 100
    Height = 100
    Visible = False
  end
  object Button1: TButton
    Left = 152
    Top = 528
    Width = 177
    Height = 65
    Cursor = crHandPoint
    Caption = 'Restart'
    Font.Charset = EASTEUROPE_CHARSET
    Font.Color = clNavy
    Font.Height = -27
    Font.Name = 'Impact'
    Font.Style = []
    ParentFont = False
    TabOrder = 0
    OnClick = FormCreate
  end
  object secSleep: TTimer
    Enabled = False
    OnTimer = secSleepTimer
    Left = 8
    Top = 16
  end
end
