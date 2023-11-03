# ListBoxItemTappedInteractions
Minimal reproduction of loss of Tapped events from touch pointers.

Run as-is, with both mouse and touch input and see that Tapped events are generated by both the Buttons and Border/Textblock controls.
Update to Avalonia 11.0.5 and see that while Buttons still generate Tapped events, the rest of the ListBoxItems and children only do so if a mouse is used.