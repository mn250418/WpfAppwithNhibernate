   M S B A M L   `   `   `  ????O  KWpfAppwithNhibernate, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:WpfAppwithNhibernateWpfAppwithNhibernate  5   	   %    WpfAppwithNhibernate.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   4local"clr-namespace:WpfAppwithNhibernate     5   	     ? Title$  
MainWindow??5   	   $	??450??6   $	??800??6)    ? 	Resources 5	      '   !WpfAppwithNhibernate.CustomerInfo   contact  validationTemplate  InputControlErrors ?? 
TargetType ?? Triggers P? Property P? Value ?? Property ?? Value ?? Self	 ?? RelativeSource
 ?? Path??%~  &	        &	      &	 ?       5
   
   6   ?? 5   
   .R?5      ]? .+?5      ?? 
???  ??$??25(?6-   $??*??6;   $??Right=?6D   6]   ?? 5      5      5      ?? 5   
   " ??6+    5      P? 5       ?@=?HasError . . ?5      ??  ?@?ToolTip 5      ?? #	 Z $)
 #(Validation.Errors)[0].ErrorContent?5      5      5      .??5      ? $??0,0,-382.6,67.2q?6    ? ColumnDefinitions 5   
   ?? 5      $??0* ?6   ?? 5      $	??56* ?6   ?? 5       $	??31* ?6   ?? 5!      $
??888* ?6   .+?5#   
   ?? -   5         ??Name$ txtCustomerId??5#      $
??Left=?6*   $	??Top=?6E   $??39.514,79,0,0q?6]   $??3??6t   $y?Hidden=?6?   ?? 5$   
   -   5        $ txtFirstName??5$      $
??Left=?6(   $??31??6C    ?? TextWrapping$
 Wrap=?6O   $	??Top=?6c   $	??155??6{   $??138.514,23,0,0q?6?   $??3??6?    =? ErrorTemplate# [ 6?   #??[ 5%      .??6>   5&      ?? 5'   
   -   5        $ txtLastName??5'      $
??Left=?6'   $??36??6B   $
 Wrap=?6N   $?? ??6b   $	??Top=?6j   $	??155??6?   $??138.514,79,0,0q?6?   $??3??6?   ?? 5(   
   -   5        $ txtMobileNumber??5(      $
??Left=?6+   $??34??6F   $
 Wrap=?6R   $??0??6f   $	??Top=?6o   $	??155??6?   $??138.514,131,0,0q?6?   $??3??6?   ?? 5*   
   -   5        $ 
txtAddress??5*      $
??Left=?6&   $??34??6A   $
 Wrap=?6M   $?? ??6a   $	??Top=?6i   $	??155??6?   $??138.514,188,0,0q?6?   $??3??6?   ?? 5+   
   -   5         ??Name$ lblFirstName??5+      $??
First Name??6&   $
??Left=?6;   $	??Top=?6V   $??37.514,28,0,0q?6n   $??3??6?   $
??Bold"?6?   ?? 5,   
   -   5        $ lblLastName??5,      $??	Last Name??6%   $
??Left=?69   $	??Top=?6T   $??39.514,79,0,0q?6l   $??3??6?   $
??Bold"?6?   ?? 5-   
   -   5        $ lblMobileNumber??5-      $??Mobile Number??6)   $
??Left=?6A   $	??Top=?6\   $??39.514,139,0,0q?6t   $??3??6?   $
??Bold"?6?   ?? 5.   
   -	   5        $ 
lblAddress??5.      $??Address??6$   $
??Left=?66   $	??Top=?6Q   $??37.514,196,0,0q?6i   $??3??6?   $
??Bold"?6?   ?? 5/   
   -
   5         ??Name$ btnAdd??5/      $	??Add??6!   $
??Left=?6/   $	??Top=?6J   $??75??6b   $??138.514,252,0,0q?6m   $??3??6?   $
??Bold"?6?   $??27??6?   6?   ?? 50   
   -   5        $ 	btnCancel??50      $??Cancel??6$   $
??Left=?65   $	??Top=?6P   $??75??6h   $??218.514,252,0,0q?6s   $??3??6?   $
??Bold"?6?   $??27??6?   6?   &   System.Windows.Controls.DataGrid  51   
   -   5          Name$ dataGridContact??51      $
??Left=?6,   $??10,302,0,-51.6q?6G   $	??Top=?6_   $	??192??6w   $	??568??6?      
IsReadOnly .    AutoGenerateColumns .  $??3??53   /   $??1??6C   ??52   %   ??    Columns 54      0  *System.Windows.Controls.DataGridTextColumn  55      ,  &System.Windows.Controls.DataGridColumn   Header$ 
First Name??6%      Width5  /System.Windows.Controls.DataGridLengthConverter$	 100 69   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6E   ?? *	FirstName+  56      $ 	Last Name??6%   $	 100 68    6D   ?? *
LastName+  57      $ Mobile Number??6%   $	 100 6<    6H   ?? *MobileNumber+  58      $ Address??6%   $	 100 66    6B   ?? *	Address+4  .System.Windows.Controls.DataGridTemplateColumn  59         CellTemplate 5:      ?? 5;      .R?5<      ?? $ btnEdit??6%   -   5        $
??Edit??5<   6   $??50??6n   ??6E   ?? *
CustomerId+6y   5=      5?        5@       5A      ?? 5B      .R?5C      ?? $ 	btnDelete??6%   -   5        $??Delete??5C   8   $??50??6r   ??6I   ?? *
CustomerId+6}   5D      5F      5I      5J      5K      