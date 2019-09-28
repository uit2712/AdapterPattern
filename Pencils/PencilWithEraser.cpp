#include "pch.h"
#include "PencilWithEraser.h"

PencilWithEraser::PencilWithEraser()
{
}

PencilWithEraser::~PencilWithEraser()
{
}

void PencilWithEraser::Draw()
{
	std::cout << "PencilWithEraser: ";
	Pencil::Draw();
}

void PencilWithEraser::Erase()
{
	std::cout << "PencilWithEraser: ";
	Eraser::Erase();
}