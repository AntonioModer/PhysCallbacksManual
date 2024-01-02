# PhysCallbacksManual

## In disabled component in script, callbacks is disabled too.

Default callbacks is still run if component disabled (OnCollisionEnter, OnCollisionStay, OnCollisionExit).

This is can be heavy for CPU if you have 1000 physics bodies.

Create/delete component with callbacks listeners is bad for garbage collector.

"if (!this.enabled) return;" in callbacks not enough ?

If you need simple turn off callbacks without delete component ?

This what you need.

Starting from Unity version 2022.

Look at for more information:
* https://docs.unity3d.com/ScriptReference/Physics.ContactEvent.html

![Screenshot](https://github.com/AntonioModer/PhysCallbacksManual/blob/main/%D0%A1%D0%BD%D0%B8%D0%BC%D0%BE%D0%BA%20%D1%8D%D0%BA%D1%80%D0%B0%D0%BD%D0%B0%202024-01-02%20211307%20en.jpg)
