#pragma once
#include <iostream>
#include "IDraw.h"

class Pencil : public IDraw
{
public:
	Pencil();
	~Pencil();

	virtual void Draw();
};