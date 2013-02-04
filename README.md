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

* Inherits the DataContext from the container.
* Can specify DependencyProperties that the container can bind to.

Example user control: Page layout.

## Data Templates

Data Templates are usually used in items controls, like ListBoxes. Define
a data template inline or as a static resource. Define as a user control for
maximum maintainability.

* Inherits DataContext from the container, usually an item in a list.
* Can select based on the type of the DataContext.

Example data template: Track selection.

## Control Templates

When you need the behavior of an existing control, but want to change
it's appearance, use a Control Template.

* Use Blend. Writing control templates by hand is very difficult.
* The container can data bind to any of the default control properties.
* Can add DependencyProperties of your own.

Example control template: Circle button.

## Content Presenters

Composition is more than building interfaces out of components. Sometimes
you need to turn it inside-out. When the container needs to put something into
a component, use a Content Presenter. You will often see a Content Presenter
in a control template.

* The container populates the content.
