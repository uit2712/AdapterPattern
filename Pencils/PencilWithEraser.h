#pragma once
#include "Pencil.h"
#include "Eraser.h"

using namespace std;

// Class Adapter: multi inheritance
class PencilWithEraser : public Pencil, public Eraser
{
public:
	PencilWithEraser();
	~PencilWithEraser();

	void Draw();
	void Erase();
};

