#ifndef OBJECTORIENTED_H
#define OBJECTORIENTED_H
 
#include <vector>
#include <algorithm>
#include <iostream>
#include <time.h>
#include <unistd.h>
 
using namespace std;
 
class ObjectOriented
{
    public:
        static void Sort(int* array, int length);
    protected:
    private:
        static vector<int> Sort(vector<int> list);
};

void ObjectOriented::Sort(int* array, int length)
{
    srand(time(0)+getpid());
    vector<int> ivector(length);
    for(int i = 0; i < length; i++)
        ivector[i] = array[i];
 
    ivector = ObjectOriented::Sort(ivector);
 
    for(int i = 0; i < length; i++)
        array[i] = ivector[i];
}
 
vector<int> ObjectOriented::Sort(vector<int> list)
{
    if (list.size() < 2)
        return list;
 
    int pivot = list[list.size() / 2];
    list.erase (list.begin() + list.size() / 2);
    vector<int> less;
    vector<int> greater;
    vector<int> result;
    for(int i = 0;i < list.size();++i)
    {
        if (list[i] > pivot)
            greater.push_back(list[i]);
        else
            less.push_back(list[i]);
    }
    less = ObjectOriented::Sort(less);
    for(int i = 0;i < less.size();++i)
        result.push_back(less[i]);
 
    result.push_back(pivot);
 
    greater = ObjectOriented::Sort(greater);
    for(int i = 0;i < greater.size();++i)
        result.push_back(greater[i]);
    return result;
}