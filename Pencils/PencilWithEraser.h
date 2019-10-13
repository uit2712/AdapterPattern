#pragma once
#include "Pencil.h"
#include "Eraser.h"

using namespace std;

// Class Adapter: multi inheritance
// Adaptee is Pencil class
class PencilWithEraser : public Pencil, private Eraser
{
public:
	PencilWithEraser();
	~PencilWithEraser();

	void Draw();
	void Erase();
};

