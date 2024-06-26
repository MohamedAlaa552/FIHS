import React, { useEffect, useState } from "react";
import {
  Actionsheet,
  ActionsheetBackdrop,
  ActionsheetContent,
  Button,
  ButtonText,
  HStack,
  VStack,
} from "@gluestack-ui/themed";
import { ActionsheetDragIndicatorWrapper } from "@gluestack-ui/themed";
import { ActionsheetDragIndicator } from "@gluestack-ui/themed";
import { Image } from "expo-image";
import { Feather } from "@expo/vector-icons";
import { useRouter } from "expo-router";
type Props = {};

const Scan = (props: Props) => {
  const [showActionsheet, setShowActionsheet] = useState(false);
  const router = useRouter();
  return (
    <>
      <Actionsheet
        isOpen={showActionsheet}
        onClose={() => setShowActionsheet(!showActionsheet)}
        zIndex={999}
      >
        <ActionsheetBackdrop />
        <ActionsheetContent h='$72' zIndex={999}>
          <ActionsheetDragIndicatorWrapper>
            <ActionsheetDragIndicator />
          </ActionsheetDragIndicatorWrapper>
          <HStack
            gap={"$3"}
            h={"$full"}
            alignItems='center'
            justifyContent='center'
          >
            <Button
              variant='outline'
              rounded={"$2xl"}
              w={160}
              h={170}
              onPress={() => {
                router.push("/(tabs)/(scan)/scanDisease");
                setShowActionsheet(!showActionsheet);
              }}
            >
              <VStack gap={"$0.5"} alignItems='center'>
                <Image
                  style={{ width: 125, height: 125, objectFit: "cover" }}
                  source={require("@/assets/images/idnetify-disease.png")}
                  alt='identify diseases'
                />
                <ButtonText>تحديد مرض النبات</ButtonText>
              </VStack>
            </Button>
            <Button
              variant='outline'
              rounded={"$2xl"}
              w={160}
              h={170}
              onPress={() => {
                router.push("/(tabs)/(scan)/scanPlant");
                setShowActionsheet(!showActionsheet);
              }}
            >
              <VStack gap={"$0.5"} alignItems='center'>
                <Image
                  style={{ width: 125, height: 125, objectFit: "cover" }}
                  source={require("@/assets/images/identify-plant.png")}
                  alt='identify plant'
                />
                <ButtonText>التعرف علي النبات</ButtonText>
              </VStack>
            </Button>
          </HStack>
        </ActionsheetContent>
      </Actionsheet>
      <Button
        onPress={() => setShowActionsheet(!showActionsheet)}
        h={65}
        w={65}
        px={"$0"}
        py={"$0"}
        transform={"translateY(5px)"}
        rounded={"$2xl"}
      >
        <Feather name='camera' color={"white"} size={28} />
      </Button>
    </>
  );
};

export default Scan;
