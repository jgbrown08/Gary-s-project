   M S B A M L   `   `   `  ����L  HRutherford.Client, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:Rutherford.Client.ViewsRutherford.Client.Views  5   	   .    (Rutherford.Client.Views.EventManagerView   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   7local%clr-namespace:Rutherford.Client.Views     5   	     � Title$  EventManagerView��5   	   $	��300��6"   $	��300��6/   .��5	      �  � RowDefinitions 5
   
   �� 5      $��35 �6   �� 5      .+�5   
   � $��0��6    � ColumnDefinitions 5      �� 5      �� 5      �� 5      �� 5      .+�5      �� $��0��6   $��	Add Event��6%   $��2q�6b   $��30��6m   ��69   ��  �� Path$ AddEventCommand�6m   �� 5      $��1��6   $��Remove Event��6%   $��2q�6h   $��30��6s   ��6<   �� $ RemoveEventCommand�6s   �� 5      $��2��6   $��
Edit Event��6%   $��2q�6d   $��30��6o   ��6:   �� $ EditEventCommand�6o   5      &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ dgEvents��5   D   $��1��6   $��Stretch=�6V   $��Stretch=�6t      SelectionMode$ Single=�5         AutoGenerateColumns .  ��5       �� $ Events� �� SelectedItem 5   *   �� $ SelectedEvent�   Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn	   Header$	 ID��6%   1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 61   �� $ EventId�  5      $
	 Name��6%   
 63   �� $
 Name�  5      $
	 Date��6%   
 63   �� $
 Date�  5      $	 Location��6%   
 67   �� $ Location�  5       $	 Price��6%   
 64   �� $ Price�  5!      $	 Total Tickets��6%   
 6<   �� $ TotalTickets�  5"      $	 Notes��6%   
 64   �� $ Notes�5$      5%      5&      