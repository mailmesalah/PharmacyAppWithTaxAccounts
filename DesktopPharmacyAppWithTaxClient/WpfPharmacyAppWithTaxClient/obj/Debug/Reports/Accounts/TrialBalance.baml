   M S B A M L   `   `   `  ????O  Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem  5   	    WpfClientApp0   *WpfClientApp.Reports.Accounts.TrialBalance   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   6sys&clr-namespace:System;assembly=mscorlib     5   	   -   5          ?Name$  TrialBalanceWindow??5   	    ? Title$ Trial Balance??5   	   $	??598??6   $	??801??6,   $??Century Gothic)?68   ???	#FF101040 ? WindowStartupLocation$ CenterScreen=?6k    ? WindowStyle$ 
ToolWindow=?6?    ? Topmost . &   System.Windows.Media.TextOptions   TextFormattingMode$ Display=?6?   $??14(?6?   
???????$??SemiBold"?6  
???????$??2q?6,   ? 
ResizeMode$ NoResize=?6@  .??5      ? $??0,0,0,0q?6   $??Right=?6    ? RowDefinitions 5   
   ?? 5	      $
??233* ?6   ?? 5
      $	??52* ?6   .+?5   
   ?? $??Financial Year??6   $
??Left=?6)   $??-263,27,0,0q?6D   $	??Top=?6Y    J? RenderTransformOrigin$ 
0.214,0.16&?6q   
???????6?   ?? 5   
   -   5        	 ??Name$	 mComboFinancialYear??5         ComboBoxAccountsStyle#???   60   ???	#FF101040???	#FFFFFFFF$
??Left=?6?   $??-154,27,0,0q?6?   $	??Top=?6?   $	??142??6?   $??25??6?   
 ?? 
IsEditable
 . $??0??6    ? 	Resources 5       ?? 
TargetType ?? Property ?? Value ?? Color??%?   '??       (?? |     5   "   *SystemColors.WindowBrushKey+)?? 5      " ??6   .?5      ??  ? ?? ?	#FF10104063   ?? 5       ? ?? ?	#FFFFFFFF63   5      ?? 5      $
 Blue??6Q   5      5      &   System.Windows.Controls.DataGrid  5   
   -   5        $??mDataGridBGroup??5         CanUserAddRows .     HeadersVisibility$ Column=?6f      CanUserReorderColumns .     CanUserResizeColumns .     CanUserResizeRows .     CanUserSortColumns .     SelectionMode$ Single=?6?      SelectionUnit$ FullRow=?6	  !   EnableColumnVirtualization .     EnableRowVirtualization .     AutoGenerateColumns .  $
??Left=?6?  $??-768,79,0,0q?6?  $	??Top=?6?  $	??757??6?  $	??372??6?  $??Normal"?6?  
??????????	#FF101040   ColumnHeaderHeight$ 30Q?6  $   HorizontalScrollBarVisibility$ Hidden=?6?  ??6*   ?? *mGridContent+ 5      =  7System.Windows.Controls.Primitives.DataGridColumnHeader*  $System.Windows.Controls.DataGridCell??%?   '        '  x     ?? 5      "  6   .?5      ??  ? ?? ?	#FF10104063   ?? 5       ? ??$ Center=?6C   5      ?? 5      "  6   .?5      ??  ? ?? ?	#FF10104063   5       5!         Columns 5#      0  *System.Windows.Controls.DataGridTextColumn  5$      ,  &System.Windows.Controls.DataGridColumn   Header$ Sl No??6%      
IsReadOnly .     Width5  /System.Windows.Controls.DataGridLengthConverter$  50 6d   1  +System.Windows.Controls.DataGridBoundColumn!   Binding! 64   ?? *
SerialNo+"   ElementStyle" 5%      ?? 5&      " ??6    .?5'      ??  ? ??$ Center=?6D   5(      5*        5+      $ Ledger??6%    . $	  350 6b   ! 65   ?? *Ledger+6b     5,      $ Debit??6%    . $
  200* 6p   ! 64   ?? *Debit+# ?? StringFormat$# N2??" 5-      ?? 5.      " ??6    .?5/      ??  ? ??$ Right=?6D   50      52        53      $ Credit??6%    . $
  200* 6s   ! 65   ?? *Credit+$# N2??" 54      ?? 55      " ??6    .?56      ??  ? ??$ Right=?6D   57      59        5:      $ 
LedgerCode??6%    . $   
Visibility$$ Hidden=?6k   ! 69   ?? *
LedgerCode+6k     5;      $ 
LedgerType??6%    . $$ Hidden=?6k   ! 69   ?? *
LedgerType+6k   %   RowDetailsTemplate% 5>      ?? 5?      .R?5@        &  Name$& mDataGridCGroup??6   -   5        $	??757??5@   ?   $
 None=?6?    .   .   .   .   .  $ Single=?6,  $ FullRow=?6C   .   .   .  $??Normal"?6?  
??????????	#FF101040$ 30Q?6?  $ Hidden=?6  ??68   ?? ' ?? ElementName$' TrialBalanceWindow??( ?? Path$( 
BGroupData? 5B        5C      $ Sl No??61    . $  50 6p   ! 6@   ?? *
SerialNo+" 5D   "   ?? 5E   &   " ??6,   .?5F   *   ??  ? ??$ Right=?6P   5G   '   5I        5J      $ Ledger??61    . $	  350 6n   ! 6A   ?? *Ledger+6n     5K      $ Debit??61    . $
  200* 6|   ! 6@   ?? *Debit+$# N2??" 5L   "   ?? 5M   &   " ??6,   .?5N   *   ??  ? ??$ Right=?6P   5O   '   5Q        5R      $ Credit??61    . $
  200* 6   ! 6A   ?? *Credit+$# N2??" 5S   "   ?? 5T   &   " ??6,   .?5U   *   ??  ? ??$ Right=?6P   5V   '   5X        5Y      $ 
LedgerCode??61    . $$ Hidden=?6w   ! 6E   ?? *
LedgerCode+6w     5Z      $ 
LedgerType??61    . $$ Hidden=?6w   ! 6E   ?? *
LedgerType+6w   % 5]      ?? 5^      .R?5_   "     $	??757??6s   $
 None=?6    .   .   .   .   .  $ Single=?6  $ FullRow=?66   .   .   .  $??Normal"?6?  
??????????	#FF101040$ 30Q?6?  $ Hidden=?6  ??6+   ?? $' TrialBalanceWindow??$( 
CGroupData? 5a   &     5b   *   $ Sl No??6=    . $  50 6|   ! 6L   ?? *
SerialNo+" 5c   .   ?? 5d   2   " ??68   .?5e   6   ??  ? ??$ Right=?6\   5f   3   5h   +     5i   *   $ Ledger??6=    . $	  350 6z   ! 6M   ?? *Ledger+6z     5j   *   $ Debit??6=    . $
  200* 6?   ! 6L   ?? *Debit+$# N2??" 5k   .   ?? 5l   2   " ??68   .?5m   6   ??  ? ??$ Right=?6\   5n   3   5p   +     5q   *   $ Credit??6=    . $
  200* 6?   ! 6M   ?? *Credit+$# N2??" 5r   .   ?? 5s   2   " ??68   .?5t   6   ??  ? ??$ Right=?6\   5u   3   5w   +     5x   *   $ 
LedgerCode??6=    . $$ Hidden=?6?   ! 6Q   ?? *
LedgerCode+6?     5y   *   $ 
LedgerType??6=    . $$ Hidden=?6?   ! 6Q   ?? *
LedgerType+6?   5{   #   5|      5      5?      5?      ?? 5?   
   -   5        $??mButtonPrint??5?      $??Print??6%   $
??Left=?65   $??-768,32,0,0q?6P   $	??Top=?6e   $	??114??6}   $??35??6?   $??1??6?   $??1??6?   ?? 5?   
   -   5        $??mButtonClose??5?      $??Close??6%   $
??Left=?65   $??-126,32,0,0q?6P   $	??Top=?6e   $	??114??6}   $??35??6?   $??2??6?   $??1??6?   6?   5?      5?      