//-------------------------------------------------------------------
// Framework for Q5
//
// TODO: Please fix any errors within this file yourself!
//
// Format of Input File:
// ----------------------
// N --> Amount of vertices in the polygon
// X Y Z --> Arbitrary vertex of polygon
// X Y Z --> Next arbitrary vertex of the polygon (repeat N times)
// NOTE: The order of the vertices are RANDOM!!!
//
// Example:
// --------
// 5
// 1 2 3
// 4 5 6
// 7 8 9
// 10 11 12
// 13 14 15
//-------------------------------------------------------------------

#include <vector>
#include <fstream>
#include <iostream>
#include <stdexcept>
#include <math.h>
#include <string>
#include <vector>
#include <tuple>
#include <algorithm>
using namespace std;

#include "matrixf.h"
#include "matrixops.h"

//-------------------------------------------------------------------
// Global Constants
//-------------------------------------------------------------------
const int SUCCESS = 0;
const int FAILURE = 1;
const double PI = std::atan(1.0) * 4;
typedef tuple<int, float> myTuple;
//-------------------------------------------------------------------
// Function Prototypes
//-------------------------------------------------------------------
Matrixf ReadFile(string fileName);
Matrixf GetMatrixRow(Matrixf & matrix, int rowNumber);
bool compare(const myTuple &lhs, const myTuple &rhs){
	return get<1>(lhs) < get<1>(rhs);
}

//-------------------------------------------------------------------
// Main application entry point
//-------------------------------------------------------------------

/**
* Main application entry point
* @param argumentCount The amount of arguments comment in
* @param arguments The list of incomming arguments
* @returns SUCCESS or FAILURE
*/
int main(int argumentCount, char **arguments)
{
	try
	{
		if (argumentCount != 2) throw runtime_error("USAGE: q5 <fileName>");

		Matrixf matrix = ReadFile(arguments[1]);
				
		// TODO: 1. Compute the normal to the polygon at each vertex
		// TODO: 2. Compute the robust vertex as per Q4
		// TODO: 3. Find the weakest vertex
		// TODO: 4. Remove the weakest vertex from the polygon
		// TODO: 5. Recompute the robust normal to the new n-1 polygon    

		// NOTE: How do I get the vertices out of the matrix? See below!
		// for (int row=0; row<matrix.nrows(); row++) 
		// {
		//	 Matrixf vertex = GetMatrixRow(matrix, row);
		//   cout << transpose(vertex);
		// }


		vector<Matrixf> vertex;
		for (int row = 0; row<matrix.nrows(); row++)
		{
			vertex.push_back(GetMatrixRow(matrix, row));
		}

		//calculate center vertex
		Matrixf centroid(3, 1);
		for (int row = 0; row < vertex.size(); row++)
		{
			centroid = GetMatrixRow(transpose(add(centroid, vertex[row])), 0);
		}

		float c1 = centroid.get(0, 0) / vertex.size();
		float c2 = centroid.get(1, 0) / vertex.size();
		float c3 = centroid.get(2, 0) / vertex.size();
		centroid.set(0, 0, c1);
		centroid.set(1, 0, c2);
		centroid.set(2, 0, c3);

		//calculate relative angle from center
		vector<myTuple> angle;

		for (int row = 0; row < vertex.size(); row++)
		{
			float a = atan2(vertex[row](1, 0) - centroid(1, 0), vertex[row](0, 0) - centroid(0, 0)) / PI;
			angle.push_back(make_tuple(row, a));
		}

		//sort
		vector<Matrixf> sortedMatrix;
		bool done = false;
		while (done != true)
		{
			for (int r = 0; r < angle.size(); r++)
			{
				if (get<1>(angle[r]) == 1)
				{
					sortedMatrix.push_back(vertex[get<0>(angle[r])]);
					angle.erase(angle.begin() + r);
				}
			}
			sort(angle.begin(), angle.end(), compare);
			for (int i = 0; i < angle.size(); i++)
			{
				sortedMatrix.push_back(vertex[get<0>(angle[i])]);

			}
			done = true;
		}

		//create edges and crossProduct
		vector<Matrixf> edge;
		for (int row = 0; row < sortedMatrix.size(); row++)
		{
			if (row == 0)
			{
				Matrixf edge1 = GetMatrixRow(transpose(subtract(sortedMatrix[row + 1], sortedMatrix[row])), 0);
				Matrixf edge2 = GetMatrixRow(transpose(subtract(sortedMatrix[sortedMatrix.size() - 1], sortedMatrix[row])), 0);
				edge.push_back(GetMatrixRow(transpose(cross(edge1, edge2)), 0));
			}
			else if (row == sortedMatrix.size() - 1) {
				Matrixf edge1 = GetMatrixRow(transpose(subtract(sortedMatrix[0], sortedMatrix[row])), 0);
				Matrixf edge2 = GetMatrixRow(transpose(subtract(sortedMatrix[row - 1], sortedMatrix[row])), 0);
				edge.push_back(GetMatrixRow(transpose(cross(edge1, edge2)), 0));
			}
			else
			{
				Matrixf edge1 = GetMatrixRow(transpose(subtract(sortedMatrix[row + 1], sortedMatrix[row])), 0);
				Matrixf edge2 = GetMatrixRow(transpose(subtract(sortedMatrix[row - 1], sortedMatrix[row])), 0);
				edge.push_back(GetMatrixRow(transpose(cross(edge1, edge2)), 0));
			}
		}
		//add all edges and get normal
		Matrixf normal(3, 1);
		for (int row = 0; row < edge.size(); row++)
		{
			normal = GetMatrixRow(transpose(add(normal, edge[row])), 0);
		}
		float n1 = normal(0, 0) / length(normal);
		float n2 = normal(1, 0) / length(normal);
		float n3 = normal(2, 0) / length(normal);
		normal.set(0, 0, n1);
		normal.set(1, 0, n2);
		normal.set(2, 0, n3);

		//weak vertex
		Matrixf weakVertex(3, 1);
		float w1 = sortedMatrix[sortedMatrix.size()-1](0,0);
		float w2 = sortedMatrix[sortedMatrix.size()-1](1, 0);
		float w3 = sortedMatrix[sortedMatrix.size()-1](2, 0);
		weakVertex.set(0, 0, w1);
		weakVertex.set(1, 0, w2);
		weakVertex.set(2, 0, w3);
		sortedMatrix.pop_back();
		
		//calculate new normal
		edge.clear();
		for (int row = 0; row < sortedMatrix.size(); row++)
		{
			if (row == 0)
			{
				
				Matrixf edge1 = GetMatrixRow(transpose(subtract(sortedMatrix[row + 1], sortedMatrix[row])), 0);
				Matrixf edge2 = GetMatrixRow(transpose(subtract(sortedMatrix[sortedMatrix.size() - 1], sortedMatrix[row])), 0);
				edge.push_back(GetMatrixRow(transpose(cross(edge1, edge2)), 0));
			}
			else if (row == sortedMatrix.size() - 1) {
				Matrixf edge1 = GetMatrixRow(transpose(subtract(sortedMatrix[0], sortedMatrix[row])), 0);
				Matrixf edge2 = GetMatrixRow(transpose(subtract(sortedMatrix[row - 1], sortedMatrix[row])), 0);
				edge.push_back(GetMatrixRow(transpose(cross(edge1, edge2)), 0));
			}
			else
			{
				Matrixf edge1 = GetMatrixRow(transpose(subtract(sortedMatrix[row + 1], sortedMatrix[row])), 0);
				Matrixf edge2 = GetMatrixRow(transpose(subtract(sortedMatrix[row - 1], sortedMatrix[row])), 0);
				edge.push_back(GetMatrixRow(transpose(cross(edge1, edge2)), 0));
			}
		}
		Matrixf newNormal(3, 1);
		for (int row = 0; row < edge.size(); row++)
		{
			newNormal = GetMatrixRow(transpose(add(newNormal, edge[row])), 0);
		}
		float nn1 = newNormal(0, 0) / length(newNormal);
		float nn2 = newNormal(1, 0) / length(newNormal);
		float nn3 = newNormal(2, 0) / length(newNormal);
		newNormal.set(0, 0, nn1);
		newNormal.set(1, 0, nn2);
		newNormal.set(2, 0, nn3);

		cout << transpose(weakVertex) << transpose(newNormal);
	}
	catch (runtime_error error)
	{
		cerr << "ERROR: " << error.what() << endl;
		return FAILURE;
	}
	return SUCCESS;
}

//-------------------------------------------------------------------
// Helper Methods
//-------------------------------------------------------------------

/**
* Read the data file that we have been given
* @param fileName The name of the file that we are reading
* @return The matrix that we read from the file
*/
Matrixf ReadFile(string fileName)
{
	ifstream file; file.open(fileName.c_str());
	if (!file.is_open()) throw runtime_error("Error: " + fileName + " could not be found!");

	int pointCount; file >> pointCount;
	Matrixf matrix(pointCount, 3);
	float value = 0;
	for (int row = 0; row<pointCount; row++)
	{
		for (int column = 0; column<3; column++)
		{
			file >> value; matrix.set(row, column, value);
		}
	}

	file.close();
	return matrix;
}

/**
* Extract a row from a matrix
* @param matrix The matrix that we are extracting the row for
* @param rowNumber The number of the row that we are working
* @return The matrix row that we are retrieving
*/
Matrixf GetMatrixRow(Matrixf & matrix, int rowNumber)
{
	Matrixf result(matrix.ncols(), 1);
	for (int column = 0; column<matrix.ncols(); column++)
	{
		float value = matrix.get(rowNumber, column);
		result.set(column, 0, value);
	}
	return result;
}
