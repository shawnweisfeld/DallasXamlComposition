Composition
===========

XAML Composition Patterns

* User Controls
* Data Templates
* Control Templates
* Content Presenters

## User Controls

User Controls are your first line of XAML composition. Use them to organize
your code and avoid a big ball of mud.

* Give each control internal whitespace.
* Put a margin around the container to balance the internal and external whitespace.

Example user control: Page layout.

## Data Templates

Data Templates are usually used in items controls, like ListBoxes. Define
a data template inline or as a static resource. Define as a user control for
maximum maintainability.

* Inherits DataContext from the container, usually an item in a list.
* Can change based on the type of the DataContext.

Example data template: Activity feed.

## Control Templates

When you need the behavior of an existing control, but want to change
it's appearance, use a Control Template.

* Use Blend. Writing control templates by hand is very difficult.
* The container can data bind to any of the default control properties.

Example control template: Circle button.

## Custom Controls

Composition is more than building interfaces out of components. Sometimes
you need to turn it inside-out. When the container needs to put something into
a component, use a Content Presenter. You will often see a Content Presenter
in a control template, to bind the Content property. But if you need more
properties, create your own custom control.

* Inherit a standard control to get its behavior.
* Add DependencyProperties of your own.
* Use TemplateBinding in a ContentPresenter to place that content.
