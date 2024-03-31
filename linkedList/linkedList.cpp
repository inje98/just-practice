#include "linkedList.h"
#include<iostream>

void InitList(tLinkedList* pList)
{
	pList->pHeadNode = nullptr;
	pList->iCount = 0;
}

void PushBack(tLinkedList* pList, int iData)
{
	// �����͸� ������ ��带 ����. PushBack�Ҷ����� ��尴ü �ϳ��� ����� ������
	tNode* pNode = (tNode*)malloc(sizeof(tNode)); // �� ��ü�� iData�� ���Ű�
	pNode->iData = iData;
	pNode->pNextNode = nullptr;  // �����͸� �޾ƿ��� �� ���� ������ ����ݾ�.
								// �� ������ ����� pNextNode�� NULL�̾����. ok?
	
	// �߰��� �����Ͱ� ó������ �ƴ���
	if (pList->iCount == 0)
	{
		pList->pHeadNode = pNode;  //ó�� ���Դٸ� pHeadNode�� ���� ���� �����Ѿ���
	}
	else
	{
		// ���� ���� ������ ��带 ã�Ƽ�
		// �� ����� pNextNode�� ���� �� ������ ���� ����Ű�� �ؾ���

		tNode* Cur = pList->pHeadNode;
		while (1)
		{
			if (Cur->pNextNode == nullptr)
			{
				break;  // ������ ���(pNextNode == NULL)�̸� ����
			}
			Cur = Cur->pNextNode; // ��� NULLã��
		}
		Cur->pNextNode = pNode; // NULL ã������ ���� �űⰡ ���ο� �� ����Ű��

	}
		++pList->iCount;

}

