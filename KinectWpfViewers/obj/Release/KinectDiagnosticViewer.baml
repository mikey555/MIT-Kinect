   M S B A M L   `   `   `  ���� ^  ZMicrosoft.Samples.Kinect.WpfViewers, Version=0.0.0.0, Culture=neutral, PublicKeyToken=nullY1clr-namespace:Microsoft.Samples.Kinect.WpfViewers#Microsoft.Samples.Kinect.WpfViewers  @    :Microsoft.Samples.Kinect.WpfViewers.KinectDiagnosticViewer   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @kt1clr-namespace:Microsoft.Samples.Kinect.WpfViewers     @d2http://schemas.microsoft.com/expression/blend/2008     .���   � Orientation$  
Horizontal=�.+��� .+��� $��12(�$��Color Image��$��Center=�;   5Microsoft.Samples.Kinect.WpfViewers.KinectColorViewer  -     Name$ kinectColorViewer��$	��400��$	��300��$��
10 0 10 10q��� .+��� $��12(�$��Depth Image��$��Center=�;   5Microsoft.Samples.Kinect.WpfViewers.KinectDepthViewer  -     Name$ kinectDepthViewer��$	��400��$	��300��$��
10 0 10 10q��� -   $��skeletonPanel��.+��� $��12(�$��Detected Skeletons��$��Center=��� -   $��skeletonCanvas��$	��400��$	��300��$��
10 0 10 10q�
���   �}�. ��  �� Orientation$ Vertical=�.+��� $��12(�$��Center=�	Framerate�� $ Vertical=�
�������
���   �.+��� -   $��	frameRate��$��72(�$��Center=�����  �� ElementName$ kinectDepthViewer�� �� Path$ 	FrameRate��� $��18(�$��Center=�FPS�� $��12(�$��Center=�Kinect Index�� 
�������
���   �.+��� -   $��kinectIndex��$��10(�$��--��$��Center=��� $��12(�$��Center=�Kinect Name�� -   $��
kinectName��$��10(�$��--��$��Center=�$��0q�
���   �
��������� $��12(�$��Center=�Status�� 
�������
���   �.+��� -   $��kinectStatus��$��36(�$��Not Connected��$��Center=�