   M S B A M L   `   `   `  ????O  Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem  5   	    WpfClientApp3   -WpfClientApp.Reports.Accounts.IncomeStatement   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   6sys&clr-namespace:System;assembly=mscorlib     5   	   -   5          ?Name$  IncomeStatementWindow??5   	    ? Title$ Income Statement??5   	   $	??551??6"   $	??801??6/   $??Century Gothic)?6;   ???	#FF101040 ? WindowStartupLocation$ CenterScreen=?6n    ? WindowStyle$ 
ToolWindow=?6?    ? Topmost . &   System.Windows.Media.TextOptions   TextFormattingMode$ Display=?6?   $??14(?6?   
???????$??SemiBold"?6  
???????$??2q?6/   ? 
ResizeMode$ NoResize=?6C  .??5      ? $??0,0,0,0q?6   $??Right=?6   .+?5	   
   (  "System.Windows.Controls.DatePicker  -   5          Name$ mDTPStartDate??5	      
 ?? Now	   SelectedDate#	 Z 6,   $
??Left=?6W   $??
-145,5,0,0q?6r   $	??Top=?6?   $	??134??6?   
   IsTodayHighlighted
 . $??0??6?   ???	#FF101040
??????? ? 	Resources 5
      :  4System.Windows.Controls.Primitives.DatePickerTextBox ?? 
TargetType ?? Property ?? Value??%Z   '        ?? 5      "  6   .?5      ??  ? ?? ?	#FF10104063   5      5      5        5   
   -   5        $ mDTPEndDate??5      #	 Z 6*   $
??Left=?6U   $??-146,35,0,0q?6p   $	??Top=?6?   $	??134??6?   
 . $??0??6?   ???	#FF101040
??????? 5      ??%Z   '        ?? 5      "  6   .?5      ??  ? ?? ?	#FF10104063   5      5      5      &   System.Windows.Controls.DataGrid  5   
   -   5        $??mDataGridBGroup??5         CanUserAddRows .     HeadersVisibility$ Column=?6A      CanUserReorderColumns .     CanUserResizeColumns .     CanUserResizeRows .     CanUserSortColumns .     SelectionMode$ Single=?6?      SelectionUnit$ FullRow=?6?   !   EnableColumnVirtualization .     EnableRowVirtualization .     AutoGenerateColumns .  $
??Left=?6[  $??-768,79,0,0q?6v  $	??Top=?6?  $	??757??6?  $	??372??6?  $??Normal"?6?  
??????????	#FF101040   ColumnHeaderHeight$ 30Q?6?  $   HorizontalScrollBarVisibility$ Hidden=?6   5      =  7System.Windows.Controls.Primitives.DataGridColumnHeader*  $System.Windows.Controls.DataGridCell??%?   '        '  x     ?? 5      "  6   .?5      ??  ? ?? ?	#FF10104063   ?? 5       ? ??$ Center=?6C   5      ?? 5      "  6   .?5       ??  ? ?? ?	#FF10104063   5!      5"         Columns 5$      0  *System.Windows.Controls.DataGridTextColumn  5%      ,  &System.Windows.Controls.DataGridColumn   Header$  ??6%      
IsReadOnly .    Width5	  /System.Windows.Controls.DataGridLengthConverter$
 200*	 6\   1
  +System.Windows.Controls.DataGridBoundColumn  
  Binding  6/   ?? *Ledger+6\     5&      $  ??6%    . $	 150	 6l     6/   ?? *Amount+! ?? StringFormat$! N2??" 
  ElementStyle" 5'      ?? 5(      " ??6    .?5)      ??  ? ??$ Right=?6D   5*      5,        5-      $  ??6%    . $	 150	 6l     6/   ?? *Total+$! N2??" 5.      ?? 5/      " ??6    .?50      ??  ? ??$ Right=?6D   51      53      55      ?? 57   
   -   5        $??mButtonPrint??57      $??Print??6%   $
??Left=?65   $??-768,472,0,0q?6P   $	??Top=?6f   $	??114??6~   $??35??6?   $??1??6?   ?? 58   
   -   5        $??mButtonClose??58      $??Close??6%   $
??Left=?65   $??-126,472,0,0q?6P   $	??Top=?6f   $	??114??6~   $??35??6?   $??2??6?   6?   5:      5;      