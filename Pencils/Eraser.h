#pragma once
#include <iostream>
#include "IErase.h"

class Eraser : public IErase
{
public:
	Eraser();
	~Eraser();

	virtual void Erase();
};

