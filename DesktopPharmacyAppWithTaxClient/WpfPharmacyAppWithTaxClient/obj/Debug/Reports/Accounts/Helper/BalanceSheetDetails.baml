   M S B A M L   `   `   `  ????O  Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem  5   	    WpfClientApp>   8WpfClientApp.Reports.Accounts.Helper.BalanceSheetDetails   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   6sys&clr-namespace:System;assembly=mscorlib     5   	   -   5          ?Name$  BalanceSheetDetailsWindow??5   	    ? Title$ Balance Sheet Details??5   	   $	??366??6'   $	??698??64   $??Century Gothic)?6@   ???	#FF101040 ? WindowStartupLocation$ CenterScreen=?6s    ? WindowStyle$ 
ToolWindow=?6?    ? Topmost . &   System.Windows.Media.TextOptions   TextFormattingMode$ Display=?6?   $??14(?6?   
???????$??SemiBold"?6
  
???????$??2q?64   ? 
ResizeMode$ NoResize=?6H  .??5      ? $??0,0,0,0q?6   $??Right=?6   .+?5
   
   &   System.Windows.Controls.DataGrid  -   5        $??mDataGridGroup??5
         CanUserAddRows .     HeadersVisibility$ Column=?6@   	   CanUserReorderColumns	 .  
   CanUserResizeColumns
 .     CanUserResizeRows .     CanUserSortColumns .     SelectionMode$ Single=?6?      SelectionUnit$ FullRow=?6?   !   EnableColumnVirtualization .     EnableRowVirtualization .     AutoGenerateColumns .  $
??Left=?6Z  $??-676,18,0,0q?6u  $	??Top=?6?  $	??665??6?  $	??255??6?  $??Normal"?6?  
??????????	#FF101040   ColumnHeaderHeight$ 30Q?6?  $   HorizontalScrollBarVisibility$ Hidden=?6   ? 	Resources 5      =  7System.Windows.Controls.Primitives.DataGridColumnHeader ?? 
TargetType ?? Property ?? Value*  $System.Windows.Controls.DataGridCell??%?   '        '  x     ?? 5      "  6   .?5      ??  ? ?? ?	#FF10104063   ?? 5       ? ??$ Center=?6C   5      ?? 5      "  6   .?5      ??  ? ?? ?	#FF10104063   5      5         Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Ledger??6%      
IsReadOnly .    Width5  /System.Windows.Controls.DataGridLengthConverter$
 200* 6b   1  +System.Windows.Controls.DataGridBoundColumn   Binding 65   ?? *Ledger+6b     5      $ Debit??6%    . $	 150 6p    64   ?? *Debit+ ?? StringFormat$ N2??   ElementStyle 5      ?? 5      " ??6    .?5      ??  ? ??$ Right=?6D   5      5        5      $ Credit??6%    . $	 150 6r    65   ?? *Credit+$ N2?? 5      ?? 5       " ??6    .?5!      ??  ? ??$ Right=?6D   5"      5$        5%      $ 
LedgerCode??6%    .    
Visibility$ Hidden=?6k    69   ?? *
LedgerCode+6k   5'      ?? 5(   
   -   5        $??mButtonClose??5(      $??Close??6%   $
??Left=?65   $??-125,291,0,0q?6P   $	??Top=?6f   $	??114??6~   $??35??6?   $??2??6?   6?   5*      5+      