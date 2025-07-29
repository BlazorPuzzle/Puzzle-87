# Puzzle #87 - What a Drag!

Carl and Jeff want to know how to make drag and drop work in a Blazor app

YouTube Video: https://youtu.be/

Blazor Puzzle Home Page: https://blazorpuzzle.com

## The Challenge

This is a .NET 9 Blazor Web App with Global Interactivity

We are trying to implement drag and drop within a list of Blazor Puzzle Episodes

It looks like it should work. We get no errors. Dragging does indeed start when you grab a drag handle, but it does not allow you to drop.

How can we make this work?

## The Solution

The solution is one little tweak.

On the `<tr>` element:

Change this:

```
@ondragover:preventDefault
```

to this:

```
ondragover="event.preventDefault()"
```

Why this works:

`ondragover="event.preventDefault()"` is sent directly to the browser as raw HTML.

We are bypassing Blazor’s event system here and telling the browser to run `preventDefault()` using native JavaScript, right in the DOM.

If you don’t call `event.preventDefault()` on the `dragover` event, the browser cancels the drop by default and never fires drop.

Boom!
