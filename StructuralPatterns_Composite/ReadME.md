# Composite Design Pattern

## Overview
The **Composite Design Pattern** allows you to treat individual objects and compositions of objects uniformly. It is typically used when dealing with tree structures, such as file systems, where both files and folders need to be treated as part of a whole.

## Use Case
- **Part-Whole Hierarchies**: When you need to represent part-whole hierarchies such as directories and files in a file system.
- **Uniform Treatment**: You want to treat a group of objects (composite) and individual objects (leaf) in the same way.

### Key Participants
1. **Component (IComponent)**: The interface or abstract class that declares common operations for both the composite and leaf elements.
2. **Leaf (FileComponent)**: Represents individual objects (files) that do not have children.
3. **Composite (FolderComponent)**: Represents objects (folders) that may contain children, which could be either leaf objects or other composite objects.
