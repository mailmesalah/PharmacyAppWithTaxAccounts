   M S B A M L   `   `   `  ????O  Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem  5   	   Q MServerServiceInterface, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null_Dclr-namespace:ServerServiceInterface;assembly=ServerServiceInterfaceServerServiceInterface 5   	    WpfClientApp'   !WpfClientApp.Barcode.PrintBarcode   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   6sys&clr-namespace:System;assembly=mscorlib     5   	   UselfDclr-namespace:ServerServiceInterface;assembly=ServerServiceInterface     5   	     ? Title$  Print Barcode??5   	   $	??547??6   $??979.4??6,   $??Century Gothic)?6:   ???	#FF101040 ? WindowStartupLocation$ CenterScreen=?6m    ? WindowStyle$ 
ToolWindow=?6?    ? Topmost . &   System.Windows.Media.TextOptions   TextFormattingMode$ Display=?6?   $??14(?6?   
???????$??SemiBold"?6  
???????$??2q?6.   ? 
ResizeMode$ NoResize=?6B   ? 	Resources 5       ?? 
TargetType ?? Property	 ?? Value
 ?? Triggers P? Property P? Value??%?   'Q?       ?? 5   
   " Q?6   .?5	      ??  ? ??	 ?	#FFFFFFFF6?   
 5
      P? 5       ?@Q?
IsSelected . . ?5      ??  ? ??$
	 Bold"?63   5      5      5      .??5      ? $??0,0,0,0q?6   $??Right=?6    ? RowDefinitions 5   
   ?? 5      $
??233* ?6   .+?5   
   ?? $
??From??6   $
??Left=?6   $??-951,18,0,0q?6:   $	??Top=?6O    J? RenderTransformOrigin$ 
0.214,0.16&?6g   
???????$??81??6?   (  "System.Windows.Controls.DatePicker  5   
   -   5          Name$ mDTPStartDate??5      
 ?? Now   SelectedDate# Z 6,   $
??Left=?6W   $??-865,20,0,0q?6r   $	??Top=?6?   $	??134??6?      IsTodayHighlighted . $??0??6?   ???	#FF101040
??????? 5      :  4System.Windows.Controls.Primitives.DatePickerTextBox??%Z   '        ?? 5      "  6   .?5      ??  ? ??	 ?	#FF10104063   5      5      5      ?? 5   
   $??To??6   $
??Left=?6   $??-716,20,0,0q?68   $	??Top=?6M   $ 
0.214,0.16&?6e   
???????$??81??6?     5    
   -   5        $ mDTPEndDate??5       # Z 6*   $
??Left=?6U   $??-630,20,0,0q?6p   $	??Top=?6?   $	??134??6?    . $??0??6?   ???	#FF101040
??????? 5!      ??%Z   '        ?? 5"      "  6   .?5#      ??  ? ??	 ?	#FF10104063   5$      5%      5&      ?? 5'   
   $??Product??6   $
??Left=?6"   $??-472,20,0,0q?6=   $	??Top=?6R   $ 
0.214,0.16&?6j   
???????$??92??6?   ?? 5(   
   -   5         ??Name$ mComboProduct??5(         ComboBoxAccountsStyle#???   6*   ???	#FF101040???	#FFFFFFFF$
??Left=?6?   $??-375,22,0,0q?6?   $	??Top=?6?   $	??191??6?   $??25??6?    ?? 
IsEditable . $??0??6?   $ 0.5,0.5&?6   5)       ?? Color??%?   '??       (?? |     5.   "   *SystemColors.WindowBrushKey+)?? 5*      " ??6   .?5+      ??  ? ??	 ?	#FF10104063   ?? 5,       ? ??	 ?	#FFFFFFFF63   5-      ?? 5.      $
 Blue??6Q   5/      50      &   System.Windows.Controls.DataGrid  52   
   -   5          Name$ 	mDataGrid??52         CanUserAddRows .     HeadersVisibility$ Column=?6b      CanUserReorderColumns .     CanUserResizeColumns .     CanUserResizeRows .     CanUserSortColumns .     SelectionMode$ Single=?6?      SelectionUnit$ FullRow=?6  !   EnableColumnVirtualization .      EnableRowVirtualization  .  !   AutoGenerateColumns! .  $
??Left=?6|  $??-948,92,0,0q?6?  $	??Top=?6?  $	??942??6?  $	??284??6?  $??Normal"?6?  
??????????	#FF101040"   ColumnHeaderHeight$" 30Q?6  $#   HorizontalScrollBarVisibility$
# Auto=?63  ??6&   ?? *mGridContent+ 53      =  7System.Windows.Controls.Primitives.DataGridColumnHeader*  $System.Windows.Controls.DataGridCell??%?   '        '  x     ?? 54      "  6   .?55      ??  ? ??	 ?	#FF10104063   ?? 56       ? ??$	 Center=?6C   57      ?? 58      "  6   .?59      ??  ? ??	 ?	#FF10104063   5:      5;      z?5<      V? 5=      .~?5>      ?? ?? 5?      T? 5@      5A      $   Columns$ 5D      4  .System.Windows.Controls.DataGridTemplateColumn  5E      ,  &System.Windows.Controls.DataGridColumn%   Header% 5F      ?? 5G      -   5        5G   >   &   CellTemplate& 5I      ?? 5J      .R?5K      ?? -   5        ' d? 	IsChecked' 5K   '   ?? *Select+( ?? UpdateSourceTrigger$( PropertyChanged=?6?   5L      5N      0	  *System.Windows.Controls.DataGridTextColumn	  5O      $% Product??6%   )   
IsReadOnly) . *   Width5
  /System.Windows.Controls.DataGridLengthConverter$	* 200
 6d   1  +System.Windows.Controls.DataGridBoundColumn+   Binding+ 66   ?? *	Product+6d   	  5P      $% Barcode??6%   ) . $	* 200
 6d   + 66   ?? *	Barcode+6d   	  5Q      $% Expiry Date??6%   ) . $	* 100
 6k   + 6:   ?? *
ExpiryDate+6k   	  5R      $% Batch??6%   ) . $	* 100
 6`   + 64   ?? *Batch+6`   	  5S      $% Quantity??6%   ) .  $	* 120
 6x   + 67   ?? *
Quantity+, ?? StringFormat$, N3??-   ElementStyle- 5T      ?? 5U      " ??6    .?5V      ??  ? ??$	 Right=?6D   5W      5Y      	  5Z      $% Purchase Rate??6%   ) . $	* 120
 6?   + 6<   ?? *PurchaseRate+$, N2??- 5[      ?? 5\      " ??6    .?5]      ??  ? ??$	 Right=?6D   5^      5`      	  5b      $% Interstate Rate??6%   ) . $	* 120
 6?   + 6>   ?? *InterstateRate+$, N2??- 5c      ?? 5d      " ??6    .?5e      ??  ? ??$	 Right=?6D   5f      5h      	  5j      $% Wholesale Rate??6%   ) . $	* 120
 6?   + 6=   ?? *WholesaleRate+$, N2??- 5k      ?? 5l      " ??6    .?5m      ??  ? ??$	 Right=?6D   5n      5p      	  5r      $	% MRP??6%   ) . $	* 120
 6m   + 62   ?? *MRP+$, N2??- 5s      ?? 5t      " ??6    .?5u      ??  ? ??$	 Right=?6D   5v      5x      	  5z      $% ProductCode??6%   ) . .   
Visibility$. Hidden=?6m   + 6:   ?? *ProductCode+6m   5}      ?? 5   
   -   5        $??mLabelTotalNo??5      $??0??6%   $
??Left=?61   $??-365,441,0,0q?6L   $	??Top=?6b   $ 
0.214,0.16&?6z   
???????$	??198??6?   $??57??6?   $
??Bold"?6?   $??32(?6?   ?? 5?   
   -   5        / ??Name$/ mButtonPrint??5?      $??Print??6'   $
??Left=?67   $??-948,463,0,0q?6R   $	??Top=?6h   $	??114??6?   $??35??6?   $??1??6?   ?? 5?   
   -	   5        $??mButtonClose??5?      $??Close??6%   $
??Left=?65   $??-120,463,0,0q?6P   $	??Top=?6f   $	??114??6~   $??35??6?   $??10??6?   0 ?? IsCancel0 . 6?   5?      5?      